using System.IO;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace notes_sync
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // if (File.Exists("./log.txt"))
            //     File.Delete("./log.txt");

            var host = CreateHostBuilder(args).Build();
            Startup.Run(host.Services);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, loggerConfiguration) =>
                {
                    loggerConfiguration.WriteTo.Console(
                        Serilog.Events.LogEventLevel.Debug);
                    // loggerConfiguration.WriteTo.File(
                    //     "./log.txt",
                    //     Serilog.Events.LogEventLevel.Warning);
                })
                .ConfigureServices(Startup.ConfigureServices)
                .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                    configHost.AddJsonFile("hostsettings.json", optional: true);
                    configHost.AddEnvironmentVariables(prefix: "PREFIX_");
                    configHost.AddCommandLine(args);
                });
    }
}
