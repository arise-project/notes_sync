using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Clean
{
    public class FolderCleaner : IFolderCleaner
    {
        readonly AppConfig conf;
        public FolderCleaner(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Remove(TextFolder tf)
        {
            return false;
        }

        public bool Remove(NoteFolder tf)
        {
            return false;
        }
    }
}
