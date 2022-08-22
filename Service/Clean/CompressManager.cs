using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Clean
{
    public class CompressManager : ICompressManager
    {
        readonly IAppConfig conf;
        public CompressManager(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool DuplicatesToDelimiter(TextFile tf)
        {
            return false;
        }
    }
}
