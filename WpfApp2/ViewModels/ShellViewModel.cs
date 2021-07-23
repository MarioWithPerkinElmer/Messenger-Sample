using DevExpress.Mvvm;
using WpfApp2.Services;

namespace WpfApp2.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        ILoggingService _logger;

        private string _message;
        public string Message
        {
            get => _message;
            set => SetValue(ref _message, value);
        }

        public ShellViewModel(ILoggingService logger)
        {
            _logger = logger;
            _logger.Log("Hello ShellViewModel!");
            Messenger.Default.Register<string>(this, MessageHandler);
            Message = "Shell Depot";
        }

        int count = 0;
        void MessageHandler(string msg)
        {
            Message = $"Shell ({++count}): {msg}";
            _logger.Log(Message);
        }
    }
}
