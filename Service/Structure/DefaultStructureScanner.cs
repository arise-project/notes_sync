using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
    public class DefaultStructureScanner : IDefaultStructureScanner
    {
        IAppConfig conf;
        public DefaultStructureScanner(IAppConfig conf)
        {
            this.conf = conf;
        }
    }
}
