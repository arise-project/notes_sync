using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class StructureSearcher : IStructureSearcher
    {
        AppConfig conf;
        public StructureSearcher(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public StructureModel Find(SdFolder sf)
        {
            return null;
        }
    }
}
