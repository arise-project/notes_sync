using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Clean
{
	public class Eraser : IEraser
	{
		IAppConfig conf;
		public Eraser(IAppConfig conf)
		{
			this.conf = conf;
		}
		
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
