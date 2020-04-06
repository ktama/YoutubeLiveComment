using System.Configuration;
using System.Windows.Media;

namespace YoutubeLiveComment
{
    public static class Setting
    {
        private static string fontFamily = string.Empty;
        private static Brush fontColor = null;
        private static int fontSize = 0;
        private static Brush background = null;
        private static double windowWidth = 0;
        private static double windowHeight = 0;
        private static string apiKey = string.Empty;
        private static string videoId = string.Empty;
        private static int commentNum = 0;
        public static string FontFamily
        {
            get
            {
                if (fontFamily == string.Empty)
                {
                    fontFamily = ConfigurationManager.AppSettings["FontFamily"];
                }
                return fontFamily;
            }
        }
        public static Brush FontColor
        {
            get
            {
                if (fontColor == null)
                {
                    var converter = new BrushConverter();
                    fontColor = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["FontColor"]);
                }
                return fontColor;
            }
        }
        public static int FontSize
        {
            get
            {
                if (fontSize == 0)
                {
                    fontSize = int.Parse(ConfigurationManager.AppSettings["FontSize"]);
                }
                return fontSize;
            }
        }
        public static Brush Background
        {
            get
            {
                if (background == null)
                {
                    var converter = new BrushConverter();
                    background = (Brush)converter.ConvertFromString(ConfigurationManager.AppSettings["Background"]);
                }
                return background;
            }
        }
        public static double WindowWidth
        {
            get
            {
                if (windowWidth == 0)
                {
                    windowWidth = double.Parse(ConfigurationManager.AppSettings["WindowWidth"]);
                }
                return windowWidth;
            }
        }
        public static double WindowHeight
        {
            get
            {
                if (windowHeight == 0)
                {
                    windowHeight = double.Parse(ConfigurationManager.AppSettings["WindowHeight"]);
                }
                return windowHeight;
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
