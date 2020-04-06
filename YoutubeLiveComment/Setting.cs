using System.Configuration;

namespace YoutubeLiveComment
{
    public static class Setting
    {
        private static string font = string.Empty;
        private static string apiKey = string.Empty;
        private static string videoId = string.Empty;
        private static int commentNum = 0;
        public static string Font
        {
            get
            {
                if (font == string.Empty)
                {
                    font = ConfigurationManager.AppSettings["Font"];
                }
                return font;
            }
        }
        public static string ApiKey
        {
            get
            {
                if (apiKey == string.Empty)
                {
                    apiKey = ConfigurationManager.AppSettings["ApiKey"];
                }
                return apiKey;
            }
        }
        public static string VideoId
        {
            get
            {
                if (videoId == string.Empty)
                {
                    videoId = ConfigurationManager.AppSettings["VideoId"];
                }
                return videoId;
            }
        }
        public static int CommentNum
        {
            get
            {
                if (commentNum == 0)
                {
                    commentNum = int.Parse(ConfigurationManager.AppSettings["CommentNum"]);
                }
                return commentNum;
            }
        }
    }
}
