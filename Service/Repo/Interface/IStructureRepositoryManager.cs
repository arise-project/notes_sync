using notes_sync.Model;

namespace notes_sync.Services.Repo.Interface
{
    public interface IStructureRepositoryManager
    {
        bool Init(RepoFolder rf);
        bool Commit(RepoFolder rf, string comment);
        bool Sync(RepoFolder rf);
    }
}
