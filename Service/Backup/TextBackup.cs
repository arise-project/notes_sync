using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Backup
{
    public class TextBackup : ITextBackup
    {
        readonly IAppConfig conf;
        public TextBackup(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Zip(TextFolder tf, BackupFolder bf)
        {
            return false;
        }
    }
}
