using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Clean
{
    public class ContentCleaner : IContentCleaner
    {
        readonly IAppConfig conf;
        public ContentCleaner(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
