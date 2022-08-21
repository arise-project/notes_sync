using notes_sync.Services.Sd.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Sd
{
    public class FolderMerger : IFolderMerger
    {
        readonly IAppConfig conf;
        public FolderMerger(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
