using System.Collections.Generic;
using notes_sync.Services.Backup.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Backup
{
	public class NoteBackup : INoteBackup
	{

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
