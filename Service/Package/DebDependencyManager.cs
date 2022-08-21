using System.Collections.Generic;
using notes_sync.Services.Package.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Package
{
    public class DebDependencyManager : IDebDependencyManager
    {
        readonly IAppConfig conf;
        public DebDependencyManager(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }


        public List<PackageModel> FindDependancies(PackageModel p)
        {
            return null;
        }

        public List<PackageModel> DownloadDependancies(PackageModel p, PackageFolder pf)
        {
            return null;
        }

        public bool FixDependencies()
        {
            return false;
        }
    }
}
