using DevExpress.Mvvm;
using WpfApp2.Services;

namespace WpfApp2.ViewModels
{
    public class ReceiverViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetValue(ref _message, value);
        }

        public ReceiverViewModel(ILoggingService logger)
        {
            logger.Log("Hello ReceiverViewModel!");
            Messenger.Default.Register<string>(this, MessageHandler);
            Message = "Receiver Depot";
        }

        int count = 0;
        void MessageHandler(string msg)
        {
            Message = $"Reiever ({++count}): {msg}";
        }
    }
}
