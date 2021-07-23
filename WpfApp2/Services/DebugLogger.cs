using System.Diagnostics;

namespace WpfApp2.Services
{
    public class DebugLogger : ILoggingService
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
