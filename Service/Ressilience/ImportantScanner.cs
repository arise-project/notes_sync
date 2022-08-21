using System.Collections.Generic;
using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Ressillence
{
    public class ImportantScanner : IImportantScanner
    {
        readonly IAppConfig conf;
        public ImportantScanner(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public List<TextFile> Find(TextFolder tf)
        {
            return null;
        }

        public List<NoteFile> Find(NoteFolder nf)
        {
            return null;
        }
    }
}
