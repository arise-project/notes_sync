using System.Collections.Generic;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Ressillence
{
    public class Hardener : IHardener
    {
        readonly AppConfig conf;
        public Hardener(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public List<TextFile> SetNames(TextFolder tf)
        {
            return null;
        }

        public List<NoteFile> SetNames(NoteFolder nf)
        {
            return null;
        }
    }
}
