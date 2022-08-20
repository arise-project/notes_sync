using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Clean
{
    public class FolderCleaner : IFolderCleaner
    {
        readonly IAppConfig conf;
        public FolderCleaner(IAppConfig conf)
        {
            this.conf = conf;
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
