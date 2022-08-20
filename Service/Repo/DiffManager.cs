using notes_sync.Services.Repo.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Repo
{
    public class DiffManager : IDiffManager
    {
        readonly IAppConfig conf;
        public DiffManager(IAppConfig conf)
        {
            this.conf = conf;
        }
    }
}
