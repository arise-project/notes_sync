using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Ressillence
{
    public class HardStructureManager : IHardStructureManager
    {
        readonly AppConfig conf;
        public HardStructureManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public HardStructure Read(RepoFolder rf)
        {
            return null;
        }
    }
}
