using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Backup
{
    public class ArchiveManager : IArchiveManager
    {
        readonly AppConfig conf;
        public ArchiveManager(IOptions<AppConfig> conf)
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
