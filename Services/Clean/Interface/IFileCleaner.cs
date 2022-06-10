namespace notes_sync_test.Services.Clean.Interface
{
	public interface IFileCleaner
	{
		bool Remove(TextFile tf);
		bool Remove(NoteFile tf);
	}	
}
