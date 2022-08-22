using Microsoft.Extensions.Options;
using notes_sync.Config;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class WrapNotesUnit : IUnit<UnitType.WrapNotes>
    {
        AppConfig conf;

        public WrapNotesUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
