using System.Collections.Generic;

namespace notes_sync_test.Services.Backup.Interface
{
	public interface INoteBackup
	{
		List<NoteFile> Scan(SdFolder sf);
		bool Move(NoteFile nf, BackupFolder bf);
	}	
}
