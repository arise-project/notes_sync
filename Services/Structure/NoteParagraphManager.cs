using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class NoteParagraphManager : INoteParagraphManager
	{
		List<Paragraph> ReadAll(TextFile tf);
		List<Paragraph> ReadAll(NoteFile nf);
	}	
}
