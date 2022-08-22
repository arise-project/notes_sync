using Microsoft.Extensions.Options;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Ressillence
{
    public class RessistanceService
    {
        readonly IAppConfig conf;
        public RessistanceService(IOptions<IAppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public string Enc(string text, string keyString)
        {
            return null;
        }

        public string Dec(string cipherText, string keyString)
        {
            return null;
        }

    }
}
