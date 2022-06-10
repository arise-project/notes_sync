using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Clean
{
	public class FileCleaner : IFileCleaner
	{
		public bool Remove(TextFile tf)
		{
			return false;
		}

		public bool Remove(NoteFile tf)
		{
			return false;
		}
	}	
}
