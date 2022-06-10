namespace notes_sync_test.Services.Backup.Interface
{
	public interface IArchiveManager
	{
		bool Zip(Folder s, Folder d, string name);
		bool ZipDiff(Folder s, Folder d, string name);
	}	
}
