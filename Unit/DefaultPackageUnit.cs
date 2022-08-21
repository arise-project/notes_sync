using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using notes_sync.Unit.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Unit
{
    //Harpun
    public class DefaultPackageUnit : IUnit<DefaultPackage>
    {
        IAppConfig conf;
        public DefaultPackageUnit(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Run(string[] args)
        {
            return false;
        }
    }
}
