using Microsoft.AspNetCore;

namespace ExpenseManagament.API
{
    public class Program
    {
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
    .ConfigureLogging(logBuilder =>
    {
        logBuilder.ClearProviders(); // removes all providers from LoggerFactory
        logBuilder.AddConsole();
        logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
    })
    .UseStartup<Startup>();
    }
}
