namespace notes_sync_test.Services.Ressillence.Interface
{
	public interface IHardSearcher
	{
		TextFile Find(TextFile tf);
		NoteFile Find(NoteFile nf);
	}	
}
