using notes_sync.Config.Interface;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{

    //Panzerhaubitze 2000
    public class RenameFilesUnit : IUnit<RenameFiles>
    {
        IAppConfig conf;
        public RenameFilesUnit(IAppConfig conf)
        {
            this.conf = conf;
        }

        public bool Run(string[] args)
        {
            //https://github.com/Humanizr/Humanizer
            return false;
        }
    }
}
