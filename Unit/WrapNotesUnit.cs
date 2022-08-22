using Microsoft.Extensions.Options;
using notes_sync.Config;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class WrapNotesUnit : IUnit
    {
        AppConfig conf;

        public WrapNotesUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public UnitType UnitType {get;} = UnitType.WrapNotes;

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
