namespace notes_sync_test.Services.Interface
{
	public interface ITextBackup
	{
		bool Zip(TextFolder tf, BackupFolder bf);
	}	
}
