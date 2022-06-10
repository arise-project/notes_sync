using System.Collections.Generic;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Ressillence
{
	public class ImportantScanner : IImportantScanner
	{
		public List<TextFile> Find(TextFolder tf)
		{
			return null;
		}
		
		public List<NoteFile> Find(NoteFolder nf)
		{
			return null;
		}
	}	
}
