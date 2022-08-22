using notes_sync.Services.Repo.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Repo
{
    public class StructureRepositoryManager : IStructureRepositoryManager
    {
        readonly AppConfig conf;
        public StructureRepositoryManager(IOptions<AppConfig> conf)
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
