using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Clean
{
    public class ContentCleaner : IContentCleaner
    {
        readonly AppConfig conf;
        public ContentCleaner(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
