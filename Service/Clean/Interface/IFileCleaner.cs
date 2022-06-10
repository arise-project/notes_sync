using notes_sync.Model;

namespace notes_sync.Services.Clean.Interface
{
	public interface IFileCleaner
	{
		bool Remove(TextFile tf);
		bool Remove(NoteFile tf);
	}	
}
