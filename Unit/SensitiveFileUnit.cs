using Microsoft.Extensions.Options;

using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class SensitiveFileUnit : IUnit<UnitType.SensitiveFile>
    {
        AppConfig conf;
        public SensitiveFileUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
