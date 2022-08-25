using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class NoteParagraphManager : INoteParagraphManager
    {
        AppConfig conf;
        public NoteParagraphManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
