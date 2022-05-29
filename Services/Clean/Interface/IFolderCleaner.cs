namespace notes_sync_test.Services.Interface
{
	public interface IFolderCleaner
	{
		bool Remove(TextFolder tf);
		bool Remove(NoteFolder tf);
	}	
}
