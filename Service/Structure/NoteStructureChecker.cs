using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Structure
{
    public class NoteStructureChecker : INoteStructureChecker
    {
        IAppConfig conf;
        public NoteStructureChecker(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
