using System.Collections.Generic;
using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Backup
{
    public class NoteBackup : INoteBackup
    {
        readonly IAppConfig conf;
        public NoteBackup(IAppConfig conf)
        {
            this.conf = conf;
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
