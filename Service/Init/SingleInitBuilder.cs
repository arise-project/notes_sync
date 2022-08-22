using notes_sync.Services.Init.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Init
{
    public class SingleInitBuilder : ISingleInitBuilder
    {

        readonly AppConfig conf;
        public SingleInitBuilder(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool SetProject(Project p)
        {
            return false;
        }

        public bool SetFrameworkFolder(FrameworkFolder ff)
        {
            return false;
        }

        public bool AddFramework(Framework f)
        {
            return false;
        }

        public bool AddPackageFolder(PackageFolder pf)
        {
            return false;
        }

        public bool Build(SdFolder sf)
        {
            return false;
        }
    }
}
