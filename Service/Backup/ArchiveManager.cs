using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Backup
{
    public class ArchiveManager : IArchiveManager
    {
        readonly IAppConfig conf;
        public ArchiveManager(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Zip(FolderModel src, FolderModel dest, string name)
        {
            return false;
        }

        public bool ZipDiff(FolderModel src, FolderModel dest, string name)
        {
            return false;
        }
    }
}
