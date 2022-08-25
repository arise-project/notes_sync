using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Clean
{
    public class CompressManager : ICompressManager
    {
        readonly AppConfig conf;
        public CompressManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool DuplicatesToDelimiter(TextFile tf)
        {
            return false;
        }
    }
}
