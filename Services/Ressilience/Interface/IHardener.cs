namespace notes_sync_test.Services.Ressillence.Interface
{
	public interface IHardener
	{
		List<TextFile> SetNames(TextFolder tf);
		List<NoteFile> SetNames(NoteFolder nf);
	}	
}
