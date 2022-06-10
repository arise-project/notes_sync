using notes_sync.Services.Repo.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Repo
{
	public class StructureRepositoryManager : IStructureRepositoryManager
	{
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
