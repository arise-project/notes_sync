using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
    public class StructureSearcher : IStructureSearcher
    {
        IAppConfig conf;
        public StructureSearcher(IAppConfig conf)
        {
            this.conf = conf;
        }

        public StructureModel Find(SdFolder sf)
        {
            return null;
        }
    }
}
