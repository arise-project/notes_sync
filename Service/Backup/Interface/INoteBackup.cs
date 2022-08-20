using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Backup.Interface
{
    public interface INoteBackup
    {
        List<NoteFile> Scan(SdFolder sf);
        bool Move(NoteFile nf, BackupFolder bf);
    }
}
