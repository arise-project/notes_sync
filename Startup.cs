using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using notes_sync.Config;
using notes_sync.Services.Backup;
using notes_sync.Services.Backup.Interface;
using notes_sync.Services.Clean;
using notes_sync.Services.Clean.Interface;
using notes_sync.Services.Init;
using notes_sync.Services.Init.Interface;
using notes_sync.Services.Package;
using notes_sync.Services.Package.Interface;
using notes_sync.Services.Repo;
using notes_sync.Services.Repo.Interface;
using notes_sync.Services.Ressillence;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Services.Script;
using notes_sync.Services.Script.Interface;
using notes_sync.Services.Sd;
using notes_sync.Services.Sd.Interface;
using notes_sync.Services.Structure;
using notes_sync.Services.Structure.Interface;
using notes_sync.Unit;
using notes_sync.Unit.Interface;
using System;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace notes_sync
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.Configure<AppConfig>(Configuration.GetSection("AppConfig"));

            //Services DI
            services.AddSingleton<IInitBuilder, InitBuilder>();
            services.AddSingleton<IImportantScanner, ImportantScanner>();

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
            var unitType = UnitType.RenameFiles;
            switch (unitType)
            {
                case UnitType.WrapNotes:
                    services.AddSingleton<IUnit, WrapNotesUnit>();
                    break;
                case UnitType.SensitiveFile:
                    services.AddSingleton<IUnit, SensitiveFileUnit>();
                    break;
                case UnitType.RenameFiles:
                    services.AddSingleton<IUnit, RenameFilesUnit>();
                    break;
                case UnitType.DefaultPackage:                
                    services.AddSingleton<IUnit, DefaultPackageUnit>();
                    break;
                default:
                    throw new NotImplementedException();
            }
            
            services.AddSingleton((f) => BuildSettings());
        }

        public void Configure(
            IApplicationBuilder app,
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
            string [] args = null;
            provider.GetService<IUnit>().Run(args);

            //NYT
            //new RenameFilesUnit().Run(args);
            //new DefaultPackageUnit().Run(args);            
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
