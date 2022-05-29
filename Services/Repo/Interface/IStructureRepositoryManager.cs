namespace notes_sync_test.Services.Interface
{
	public interface IStructureRepositoryManager
	{
		bool Init(RepoFolder rf);
		bool Commit(RepoFolder rf, string comment);
		bool Sync(RepoFolder rf);
	}	
}
