namespace notes_sync_test.Services.Clean.Interface
{
	public interface IEraser
	{
	      bool Remove(NoteFile nf, Paragraph p);
		  bool ReplaceFolder(TextFolder tf, TextFolder tf);
		  bool ReplaceFolder(NoteFolder tf, TextFolder tf);
	}	
}
