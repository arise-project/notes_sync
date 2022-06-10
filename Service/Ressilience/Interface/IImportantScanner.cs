using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Ressillence.Interface
{
	public interface IImportantScanner
	{
		List<TextFile> Find(TextFolder tf);
		List<NoteFile> Find(NoteFolder nf);
	}	
}
