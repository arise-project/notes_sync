namespace notes_sync_test.Services.Clean.Interface
{
	public interface ICompressManager
	{
		bool DuplicatesToDelimiter(TextFile tf);
	}	
}