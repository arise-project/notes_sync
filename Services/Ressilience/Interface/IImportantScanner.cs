namespace notes_sync_test.Services.Interface
{
	public interface IImportantScanner
	{
		List<TextFile> Find(TextFolder tf);
		List<NoteFile> Find(NoteFolder nf);
	}	
}
