using notes_sync.Services.Structure.Interface;
using notes_sync.Model;

using notes_sync.Unit.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Unit
{
    //Harpun
    public class DefaultPackageUnit : IUnit<UnitType.DefaultPackage>
    {
        AppConfig conf;
        public DefaultPackageUnit(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
