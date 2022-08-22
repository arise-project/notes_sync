using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace notes_sync
{
    static class Program
    {
        public static void Main(string[] args)
        {
            if (File.Exists("./log.txt"))
                File.Delete("./log.txt");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, loggerConfiguration) =>
                {
                    loggerConfiguration.WriteTo.Console(Serilog.Events.LogEventLevel.Error);
                    loggerConfiguration.WriteTo.File("./log.txt", Serilog.Events.LogEventLevel.Warning);
                })
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
