using DevExpress.Mvvm;
using WpfApp2.Services;

namespace WpfApp2.ViewModels
{
    public class SenderViewModel : ViewModelBase
    {
        public DelegateCommand UpdateCommand { get; private set; }

        public bool IsUpdateCommandEnabled
        {
            get => GetProperty(() => IsUpdateCommandEnabled);
            set => SetProperty(() => IsUpdateCommandEnabled, value);
        }

        void UpdateCommandExecute()
        {
            Messenger.Default.Send<string>($"Hello from Sender!");
        }

        bool UpdateCommandCanExecute()
        {
            return IsUpdateCommandEnabled;
        }

        public SenderViewModel(ILoggingService logger)
        {
            logger.Log("Hello SenderViewModel!");
            IsUpdateCommandEnabled = true;
            UpdateCommand = new DelegateCommand(UpdateCommandExecute, UpdateCommandCanExecute, false);
        }
    }
}
