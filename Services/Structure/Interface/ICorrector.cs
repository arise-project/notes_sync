namespace notes_sync_test.Services.Structure.Interface
{
	public interface ICorrector
	{
		bool RenameToSimple(TextFile tf);
		bool RenameToSimple(NoteFile tf);
	}	
}
