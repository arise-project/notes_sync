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
using notes_sync.Service;
using notes_sync.Service.Interface;
using notes_sync.Backup;
using notes_sync.Backup.Interface;
using notes_sync.Clean;
using notes_sync.Clean.Interface;
using notes_sync.Init;
using notes_sync.Init.Interface;
using notes_sync.Package;
using notes_sync.Package.Interface;
using notes_sync.Repo;
using notes_sync.Repo.Interface;
using notes_sync.Ressilience;
using notes_sync.Ressilience.Interface;
using notes_sync.Script;
using notes_sync.Script.Interface;
using notes_sync.Sd;
using notes_sync.Sd.Interface;
using notes_sync.Structure;
using notes_sync.Structure.Interface;

namespace notes_sync
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<AppConfiguration>(Configuration.GetSection("AppConfig"));
	    
		    //Services DI
		    services.AddSingleton<InitBuilder, nitBuilder>();
			services.AddSingleton<ImportantScanner, mportantScanner>();

			services.AddSingleton<IArchiveManager, ArchiveManager>();
			services.AddSingleton<INoteBackup, NoteBackup>();
			services.AddSingleton<ITextBackup, TextBackup>();

			services.AddSingleton<ICompressManager, CompressManager>();
			services.AddSingleton<IContentCleaner, ContentCleaner>();
			services.AddSingleton<IEraser, Eraser>();
			services.AddSingleton<IFileCleaner, FileCleaner>();
			services.AddSingleton<IFolderCleaner, FolderCleaner>();

			services.AddSingleton<IInitBuilder, InitBuilder>();
			services.AddSingleton<ISingleInitBuilder, SingleInitBuilder>();

			services.AddSingleton<IDebDependencyManager, DebDependencyManager>();
			services.AddSingleton<IDebManager, DebManager>();

			services.AddSingleton<IDiffManager, DiffManager>();
			services.AddSingleton<IStructureRepositoryManager, StructureRepositoryManager>();

			services.AddSingleton<IHardener, Hardener>();
			services.AddSingleton<IHardSearcher, HardSearcher>();
			services.AddSingleton<IHardStructureManager, HardStructureManager>();
			services.AddSingleton<IImportantScanner, ImportantScanner>();

			services.AddSingleton<IProcessRunner, ProcessRunner>();
			services.AddSingleton<IScriptManager, ScriptManager>();

			services.AddSingleton<ICapacityManager, CapacityManager>();
			services.AddSingleton<IFolderMerger, FolderMerger>();
			services.AddSingleton<IFolderWalker, FolderWalker>();

			services.AddSingleton<ICorrector, Corrector>();
			services.AddSingleton<IDefaultStructureScanner, DefaultStructureScanner>();
			services.AddSingleton<INoteParagraphManager, NoteParagraphManager>();
			services.AddSingleton<INoteStructureChecker, NoteStructureChecker>();
			services.AddSingleton<IReportManager, ReportManager>();
			services.AddSingleton<IStructureMerger, StructureMerger>();
			services.AddSingleton<IStructureSearcher, StructureSearcher>();
        	
        	//Units DI
        	services.AddSingleton<IUnit<WrapNotes>, WrapNotesUnit>();
   			services.AddSingleton<IUnit<SensitiveFile>, SensitiveFileUnit>();
      		services.AddSingleton<IUnit<RenameFiles>, RenameFilesUnit>();
        	services.AddSingleton<IUnit<DefaultPackage>, DefaultPackageUnit>();
        	        
		    services.AddSingleton((f) => BuildSettings());
        }

        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env, 
            IServiceProvider provider)
        {
            //PZRK Perun
        	//FH70
        	//Igla
            Console.WriteLine("Notes Sync");
            
            //AppConfig appConfig = provider.GetService<IOptions<AppConfig>>().Value;
            Console.WriteLine("==================================");
            Console.WriteLine("App Config:");
            //Console.WriteLine(JsonConvert.SerializeObject(appConfig));
            Console.WriteLine("==================================");
            provider.GetService<IDefaultPackageUnit>().Run(args);
            
            //NYT
        	//new RenameFilesUnit().Run(args);
        	new DefaultPackageUnit().Run(args);            
        }

        public Settings BuildSettings()
        {
            string text = System.IO.File.ReadAllText("RuleSettings.yml");
            
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
