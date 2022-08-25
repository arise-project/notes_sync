using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class Corrector : ICorrector
    {
        AppConfig conf;
        public Corrector(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
