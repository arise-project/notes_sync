namespace notes_sync_test.Services.Ressillence.Interface
{
	public interface IImportantScanner
	{
		List<TextFile> Find(TextFolder tf);
		List<NoteFile> Find(NoteFolder nf);
	}	
}
