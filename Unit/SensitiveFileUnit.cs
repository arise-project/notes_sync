using Microsoft.Extensions.Options;
using notes_sync.Config;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class SensitiveFileUnit : IUnit
    {
        AppConfig conf;
        public SensitiveFileUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public UnitType UnitType {get;} = UnitType.SensitiveFile;

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
