using System.Collections.Generic;
using notes_sync.Services.Init.Interface;
using notes_sync.Services.Sd;
using notes_sync.Services.Script;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Init
{
    public class InitManager
    {
        readonly ScriptManager scr;
        readonly AppConfig conf;
        public InitManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public InitManager(ScriptManager scr)
        {
            this.scr = scr;
        }

        public bool Run(List<SdFolder> sfs)
        {
            bool r = true;
            foreach (var sf in sfs)
            {
                //ScriptFile scf = fm.FullInit(sf);
                //r &= scr.Run(scf);
            }

            return r;
        }
    }
}
