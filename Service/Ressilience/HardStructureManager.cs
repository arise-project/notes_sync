using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Ressillence
{
	public class HardStructureManager : IHardStructureManager
	{
		IAppConfig conf;
		public HardStructureManager(IAppConfig conf)
		{
			this.conf = conf;
		}

		public HardStructure Read(RepoFolder rf)
		{
			return null;
		}
	}
}
