using System.Windows;

namespace YoutubeLiveComment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MouseLeftButtonDown += (sender, e) => { DragMove(); };

            // フォントの設定
            FontSize = Setting.FontSize;
            Foreground = Setting.FontColor;
            Background = Setting.Background;
        }
    }
}
