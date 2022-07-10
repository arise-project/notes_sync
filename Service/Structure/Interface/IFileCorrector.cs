using notes_sync.Model;

namespace notes_sync.Services.Structure.Interface
{
	public interface IFileCorrector
	{
		bool RenameToSimple(TextFile tf);
		bool RenameToSimple(NoteFile tf);
	}	
}
