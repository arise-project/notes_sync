using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Ressillence
{
    public class HardStructureManager : IHardStructureManager
    {
        readonly IAppConfig conf;
        public HardStructureManager(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public HardStructure Read(RepoFolder rf)
        {
            return null;
        }
    }
}
