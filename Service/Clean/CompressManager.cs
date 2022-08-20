using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Clean
{
    public class CompressManager : ICompressManager
    {
        readonly IAppConfig conf;
        public CompressManager(IAppConfig conf)
        {
            this.conf = conf;
        }

        public bool DuplicatesToDelimiter(TextFile tf)
        {
            return false;
        }
    }
}
