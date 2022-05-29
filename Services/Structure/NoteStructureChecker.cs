using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class NoteStructureChecker : INoteStructureChecker
	{
		bool Verify(TextFile tf);
		bool Verify(NoteFile tf);
	}	
}
