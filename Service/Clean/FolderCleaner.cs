using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Clean
{
    public class FolderCleaner : IFolderCleaner
    {
        readonly IAppConfig conf;
        public FolderCleaner(IOptions<IAppConfig> conf)
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
