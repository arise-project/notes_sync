using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using aspose_health_check.Service;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using aspose_health_check.Git;
using aspose_health_check.Helper;
using aspose_health_check.Models.Settings;
using aspose_health_check.Parser.Interface;
using aspose_health_check.Parser;
using aspose_health_check.Service.Interface;
using aspose_health_check.Translate;

namespace notes_sync
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            //services.Configure<AppConfig>(Configuration.GetSection("AppConfig"));

            //services.AddSingleton((f) => BuildSettings());
            //services.AddSingleton<IResourceWritter, TomlWritter>();
        }

        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env, 
            IServiceProvider provider)
        {
            //AppConfig appConfig = provider.GetService<IOptions<AppConfig>>().Value;
            Console.WriteLine("==================================");
            Console.WriteLine("App Config:");
            //Console.WriteLine(JsonConvert.SerializeObject(appConfig));
            Console.WriteLine("==================================");
            //provider.GetService<IServiceBuilder>().Run();

            
        }

        public Settings BuildSettings()
        {
            string text = System.IO.File.ReadAllText(@"RuleSettings.yml");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Rule Settings:");
            Console.WriteLine(text);
            Console.WriteLine("----------------------------------");
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<Settings>(text);
        }
    }
}
