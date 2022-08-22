using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Ressillence
{
    public class HardSearcher : IHardSearcher
    {
        readonly AppConfig conf;
        public HardSearcher(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public TextFile Find(TextFile tf)
        {
            return null;
        }

        public NoteFile Find(NoteFile nf)
        {
            return null;
        }
    }
}
