using notes_sync.Services.Sd.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Sd
{
    public class FolderWalker : IFolderMerger
    {
        readonly AppConfig conf;
        public FolderWalker(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
