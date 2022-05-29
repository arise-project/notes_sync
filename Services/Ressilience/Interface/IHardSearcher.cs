namespace notes_sync_test.Services.Interface
{
	public interface IHardSearcher
	{
		TextFile Find(TextFile tf);
		NoteFile Find(NoteFile nf);
	}	
}
