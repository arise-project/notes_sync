using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Structure
{
    public class StructureSearcher : IStructureSearcher
    {
        IAppConfig conf;
        public StructureSearcher(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public StructureModel Find(SdFolder sf)
        {
            return null;
        }
    }
}
