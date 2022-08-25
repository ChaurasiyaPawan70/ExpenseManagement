namespace ExpenseManagament.API;

/// <summary>
/// The Main function can be used to run the ASP.NET Core application locally using the Kestrel webserver.
/// </summary>
public class LocalEntryPoint
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
        .ConfigureLogging(logBuilder =>
        {
            logBuilder.ClearProviders(); // removes all providers from LoggerFactory
            logBuilder.AddConsole();
            logBuilder.AddTraceSource("Information, ActivityTracing"); // Add Trace listener provider
        })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}