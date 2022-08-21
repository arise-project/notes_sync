using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Structure
{
    public class NoteCorrector : INoteCorrector
    {
        IAppConfig conf;
        public NoteCorrector(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public void NewLineForSentence(NoteFile nf)
        {

        }
    }
}
