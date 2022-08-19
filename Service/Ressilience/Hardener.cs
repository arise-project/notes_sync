using System.Collections.Generic;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Ressillence
{
	public class Hardener : IHardener
	{
		IAppConfig conf;
		public Hardener(IAppConfig conf)
		{
			this.conf = conf;
		}
		
		public List<TextFile> SetNames(TextFolder tf)
		{
			return null;
		}

		public List<NoteFile> SetNames(NoteFolder nf)
		{
			return null;
		}
	}
}
