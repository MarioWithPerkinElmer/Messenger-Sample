using System.Windows;
using Microsoft.Extensions.DependencyInjection;

using WpfApp2.ViewModels;

namespace WpfApp2
{
    public partial class ShellView : Window
    {
        public ShellView()
        {
            InitializeComponent();
            DataContext = ShellVM;
            Send.DataContext = SendVM;
            Receive.DataContext = ReceiveVM;
        }

        internal ShellViewModel ShellVM = App.ServicesProvider.GetRequiredService<ShellViewModel>();
        internal SenderViewModel SendVM = App.ServicesProvider.GetRequiredService<SenderViewModel>();
        internal ReceiverViewModel ReceiveVM = App.ServicesProvider.GetRequiredService<ReceiverViewModel>();
    }
}
