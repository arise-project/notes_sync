using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Structure
{
	public class Corrector : ICorrector
	{
		public bool RenameToSimple(TextFile tf)
		{
			return false;
		}

		public bool RenameToSimple(NoteFile tf)
		{
			return false;
		}
	}
}
