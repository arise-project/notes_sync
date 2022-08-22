using notes_sync.Services.Repo.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Repo
{
    public class DiffManager : IDiffManager
    {
        readonly AppConfig conf;
        public DiffManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
