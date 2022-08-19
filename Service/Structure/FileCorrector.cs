using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
	public class FileCorrector : IFileCorrector
	{
		IAppConfig conf;
		public FileCorrector(IAppConfig conf)
		{
			this.conf = conf;
		}
		
		public bool RenameToSimple(TextFile tf)
		{
			return false;
		}

		public bool RenameToSimple(NoteFile tf)
		{
			return false;
		}
	}
}
