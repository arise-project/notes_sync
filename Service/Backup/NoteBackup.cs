using System.Collections.Generic;
using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Backup
{
    public class NoteBackup : INoteBackup
    {
        readonly IAppConfig conf;
        public NoteBackup(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public List<NoteFile> Scan(SdFolder sf)
        {
            return null;
        }


        public bool Move(NoteFile nf, BackupFolder bf)
        {
            return false;
        }
    }
}
