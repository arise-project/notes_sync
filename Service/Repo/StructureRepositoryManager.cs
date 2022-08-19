using notes_sync.Services.Repo.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Repo
{
	public class StructureRepositoryManager : IStructureRepositoryManager
	{
		IAppConfig conf;
		public StructureRepositoryManager(IAppConfig conf)
		{
			this.conf = conf;
		}

		public bool Init(RepoFolder rf)
		{
			return false;
		}

		public bool Commit(RepoFolder rf, string comment)
		{
			return false;
		}

		public bool Sync(RepoFolder rf)
		{
			return false;
		}
	}
}
