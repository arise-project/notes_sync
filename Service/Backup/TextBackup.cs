using notes_sync.Services.Backup.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Backup
{
	public class TextBackup : ITextBackup
	{
		public bool Zip(TextFolder tf, BackupFolder bf)
		{
			return false;
		}
	}
}
