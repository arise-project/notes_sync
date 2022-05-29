uisng System.Collections.Generic;

namespace notes_sync_test.Services.Interface
{
	public interface INoteBackup
	{
		List<NoteFile> Scan(SdFolder sf);
		bool Move(NoteFile nf, BackupFolder bf);
	}	
}
