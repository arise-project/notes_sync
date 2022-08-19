using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
	public class NoteStructureChecker : INoteStructureChecker
	{
		IAppConfig conf;
		public NoteStructureChecker(IAppConfig conf)
		{
			this.conf = conf;
		}
	}	
}
