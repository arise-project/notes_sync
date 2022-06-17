using System;
using System.IO;
using notes_sync.Unit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.IO;

namespace notes_sync
{
    class Program
    {
    	public static void Main(string[] args)
        {
            if (File.Exists("./log.txt"))
                File.Delete("./log.txt");

            CreateHostBuilder(args).Build().Run();
        }
        
        static void Main1(string[] args)
        {
        	//PZRK Perun
        	//FH70
        	//Igla
            Console.WriteLine("Notes Sync");
            
            //NYT
        	//new RenameFilesUnit().Run(args);
        	
        	new DefaultPackageUnit().Run(args);
        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog((context, loggerConfiguration) =>
                {
                    loggerConfiguration.WriteTo.Console(
                        Serilog.Events.LogEventLevel.Error);
                    loggerConfiguration.WriteTo.File(
                        "./log.txt",
                        Serilog.Events.LogEventLevel.Warning);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
