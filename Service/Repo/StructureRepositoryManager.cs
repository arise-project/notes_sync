using notes_sync.Services.Repo.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Repo
{
    public class StructureRepositoryManager : IStructureRepositoryManager
    {
        readonly IAppConfig conf;
        public StructureRepositoryManager(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
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
