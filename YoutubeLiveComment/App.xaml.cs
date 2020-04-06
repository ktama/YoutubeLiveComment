using System.Windows;

namespace YoutubeLiveComment
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var font = new System.Windows.Media.FontFamily(Setting.FontFamily);
            var style = new Style(typeof(Window));
            style.Setters.Add((new Setter(Window.FontFamilyProperty, font)));

            FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata(style));
        }
    }
}
