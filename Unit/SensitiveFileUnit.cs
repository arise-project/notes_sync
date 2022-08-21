using Microsoft.Extensions.Options;
using notes_sync.Config.Interface;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class SensitiveFileUnit : IUnit<SensitiveFile>
    {
        IAppConfig conf;
        public SensitiveFileUnit(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
