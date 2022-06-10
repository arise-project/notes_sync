using notes_sync.Model;

namespace notes_sync.Services.Clean.Interface
{
	public interface IFolderCleaner
	{
		bool Remove(TextFolder tf);
		bool Remove(NoteFolder tf);
	}	
}
