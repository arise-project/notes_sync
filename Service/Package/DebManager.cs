using System.Collections.Generic;
using notes_sync.Services.Package.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Package
{
    public class DebManager : IDebManager
    {
        readonly IAppConfig conf;
        public DebManager(IAppConfig conf)
        {
            this.conf = conf;
        }

        //M109
        public PackageFolder Find(PackageModel p)
        {
            return null;
        }
    }
}
