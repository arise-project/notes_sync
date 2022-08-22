using Microsoft.Extensions.Options;

using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{

    //Panzerhaubitze 2000
    public class RenameFilesUnit : IUnit<UnitType.RenameFiles>
    {
        AppConfig conf;
        public RenameFilesUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            //https://github.com/Humanizr/Humanizer
            return false;
        }
    }
}
