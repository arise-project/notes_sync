using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Backup
{
    public class TextBackup : ITextBackup
    {
        readonly IAppConfig conf;
        public TextBackup(IAppConfig conf)
        {
            this.conf = conf;
        }

        public bool Zip(TextFolder tf, BackupFolder bf)
        {
            return false;
        }
    }
}
