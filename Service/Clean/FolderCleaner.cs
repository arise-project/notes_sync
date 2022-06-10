using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Clean
{
	public class FolderCleaner : IFolderCleaner
	{
		public bool Remove(TextFolder tf)
		{
			return false;
		}

		public bool Remove(NoteFolder tf)
		{
			return false;
		}
	}	
}
