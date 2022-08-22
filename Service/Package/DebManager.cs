using System.Collections.Generic;
using notes_sync.Services.Package.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Package
{
    public class DebManager : IDebManager
    {
        readonly AppConfig conf;
        public DebManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        //M109
        public PackageFolder Find(PackageModel p)
        {
            return null;
        }
    }
}
