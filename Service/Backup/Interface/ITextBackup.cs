using notes_sync.Model;

namespace notes_sync.Services.Backup.Interface
{
	public interface ITextBackup
	{
		bool Zip(TextFolder tf, BackupFolder bf);
	}	
}
