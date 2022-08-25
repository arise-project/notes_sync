using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class FileCorrector : IFileCorrector
    {
        AppConfig conf;
        public FileCorrector(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool RenameToSimple(TextFile tf)
        {
            return false;
        }

        public bool RenameToSimple(NoteFile tf)
        {
            return false;
        }
    }
}
