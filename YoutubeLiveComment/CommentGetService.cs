using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YoutubeLiveComment
{
    public class CommentGetService
    {
        private MainWindowViewModel viewModel;
        private YouTubeService youtubeService;
        private string liveCommentId;
        private string nextPageToken = null;
        private List<string> commentList = new List<string>();

        public int Interval { get; private set; }

        public CommentGetService(MainWindowViewModel vm)
        {
            viewModel = vm;
            youtubeService = CreateYoutubeService();
            liveCommentId = GetLiveCommentId(youtubeService);
        }

        public async Task GetLiveCommentMessage()
        {
            var liveChatRequest = youtubeService.LiveChatMessages.List(liveCommentId, "snippet,authorDetails");
            liveChatRequest.PageToken = nextPageToken;
            var liveChatResponse = await liveChatRequest.ExecuteAsync();
            foreach (var liveChat in liveChatResponse.Items)
            {
                try
                {
                    SetComment($"{liveChat.AuthorDetails.DisplayName}, {liveChat.Snippet.DisplayMessage}");
                }
                catch { }
            }
            nextPageToken = liveChatResponse.NextPageToken;
            Interval = (int)liveChatResponse.PollingIntervalMillis;
        }

        private YouTubeService CreateYoutubeService()
        {
            return new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = Setting.ApiKey
            });
        }

        private string GetLiveCommentId(YouTubeService youTubeService)
        {
            var videoList = youTubeService.Videos.List("LiveStreamingDetails");
            videoList.Id = Setting.VideoId;

            var videoListResponse = videoList.Execute();
            foreach (var videoId in videoListResponse.Items)
            {
                return videoId.LiveStreamingDetails.ActiveLiveChatId;
            }

            return null;
        }

        private void SetComment(string comment)
        {
            for (; commentList.Count >= Setting.CommentNum;)
            {
                commentList.RemoveAt(0);
            }
            commentList.Add(comment);

            viewModel.CommentBox = string.Join("\n", commentList);
        }
    }
}
