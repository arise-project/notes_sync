using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Backup
{
    public class TextBackup : ITextBackup
    {
        readonly AppConfig conf;
        public TextBackup(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Zip(TextFolder tf, BackupFolder bf)
        {
            return false;
        }
    }
}
