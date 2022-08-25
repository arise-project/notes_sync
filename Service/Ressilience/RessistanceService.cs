using Microsoft.Extensions.Options;

using notes_sync.Config;

namespace notes_sync.Services.Ressillence
{
    public class RessistanceService
    {
        readonly AppConfig conf;
        public RessistanceService(IOptions<AppConfig> conf)
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
