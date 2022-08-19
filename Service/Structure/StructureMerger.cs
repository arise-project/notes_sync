using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
	public class StructureMerger : IStructureMerger
	{
		IAppConfig conf;
		public StructureMerger(IAppConfig conf)
		{
			this.conf = conf;
		}
	}	
}
