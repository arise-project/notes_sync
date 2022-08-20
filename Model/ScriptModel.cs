using notes_sync.Config;
using notes_sync.Config.Interface;

namespace notes_sync.Model
{
    public class ScriptModel : ProcessModel
    {
        public void Init(IAppConfig ac)
        {
            Command = ac.ScriptCommand.Command;
        }
    }
}
