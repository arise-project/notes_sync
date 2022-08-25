using notes_sync.Config;


namespace notes_sync.Model
{
    public class ScriptModel : ProcessModel
    {
        public void Init(AppConfig ac)
        {
            Command = ac.ScriptCommand.Command;
        }
    }
}
