namespace notes_sync_test.Services.Backup.Interface
{
	public interface ITextBackup
	{
		bool Zip(TextFolder tf, BackupFolder bf);
	}	
}
