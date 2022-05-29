using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class FolderMerger : IFolderMerger
	{
		bool Create(TextFolder tf);
		bool Create(NoteFolder nf);
		bool Delete(TextFolder tf);
		bool Delete(NoteFolder nf);
	}	
}
