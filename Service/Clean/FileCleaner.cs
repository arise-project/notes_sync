using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Clean
{
    public class FileCleaner : IFileCleaner
    {
        readonly AppConfig conf;
        public FileCleaner(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Remove(TextFile tf)
        {
            return false;
        }

        public bool Remove(NoteFile tf)
        {
            return false;
        }
    }
}
