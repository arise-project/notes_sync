namespace notes_sync_test.Services.Interface
{
	public interface IHardener
	{
		List<TextFile> SetNames(TextFolder tf);
		List<NoteFile> SetNames(NoteFolder nf);
	}	
}
