using notes_sync.Services.Sd.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Sd
{
    public class FolderMerger : IFolderMerger
    {
        readonly IAppConfig conf;
        public FolderMerger(IAppConfig conf)
        {
            this.conf = conf;
        }
    }
}
