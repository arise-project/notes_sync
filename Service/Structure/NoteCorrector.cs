using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class NoteCorrector : INoteCorrector
    {
        AppConfig conf;
        public NoteCorrector(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public void NewLineForSentence(NoteFile nf)
        {

        }
    }
}
