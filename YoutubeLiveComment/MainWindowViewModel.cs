using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace YoutubeLiveComment
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private CommentGetService service;
        private DispatcherTimer timer = new DispatcherTimer();
        private string commentBox = string.Empty;
        public string CommentBox
        {
            get { return commentBox; }
            set
            {
                if (value != commentBox)
                {
                    commentBox = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public MainWindowViewModel()
        {
            service = new CommentGetService(this);
            SetupTimer();
        }

        ~MainWindowViewModel()
        {
            timer.Stop();
        }

        private async void MyTimerMethod(object sender, EventArgs e)
        {
            await Task.Run(() => service.GetLiveCommentMessage());
        }

        private void SetupTimer()
        {
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Tick += new EventHandler(MyTimerMethod);
            timer.Start();
        }
    }
}
