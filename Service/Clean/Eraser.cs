using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Clean
{
	public class Eraser : IEraser
	{
	      public bool Remove(NoteFile nf, Paragraph p)
		  {
		  	return false;
		  }
		  
		  public bool ReplaceFolder(TextFolder scr, TextFolder dest)
		  {
		  	return false;
		  }

		  public bool ReplaceFolder(NoteFolder src, TextFolder dest)
		  {
		  	return false;
		  }
	}	
}
