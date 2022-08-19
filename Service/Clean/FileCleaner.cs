using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Clean
{
	public class FileCleaner : IFileCleaner
	{
		IAppConfig conf;
		public FileCleaner(IAppConfig conf)
		{
			this.conf = conf;
		}

		public bool Remove(TextFile tf)
		{
			return false;
		}

		public bool Remove(NoteFile tf)
		{
			return false;
		}
	}	
}
