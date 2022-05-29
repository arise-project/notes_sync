using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class FolderWalker : IFolderWalker
	{
		List<TextFile> Walk(TextFolder tf);
		List<NoteFile> Walk(NoteFolder tf);
	}	
}
