using System;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

using WpfApp2.Services;
using WpfApp2.ViewModels;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ServiceProvider ServicesProvider;

        public App()
        {
            ServicesProvider = ConfigureServices() as ServiceProvider;
        }

        private IServiceProvider ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<ILoggingService, DebugLogger>();
            services.AddTransient<ShellViewModel>();
            services.AddTransient<SenderViewModel>();
            services.AddTransient<ReceiverViewModel>();

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new ShellView();
            MainWindow.Show();
        }
    }
}
