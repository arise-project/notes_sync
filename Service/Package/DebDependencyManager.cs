using System.Collections.Generic;
using notes_sync.Services.Package.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Package
{
    public class DebDependencyManager : IDebDependencyManager
    {
        readonly AppConfig conf;
        public DebDependencyManager(IOptions<AppConfig> conf)
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
