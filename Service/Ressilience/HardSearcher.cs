using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Ressillence
{
    public class HardSearcher : IHardSearcher
    {
        readonly IAppConfig conf;
        public HardSearcher(IOptions<IAppConfig> conf)
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
