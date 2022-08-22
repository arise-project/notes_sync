using System.Collections.Generic;
using notes_sync.Services.Init.Interface;
using notes_sync.Services.Sd;
using notes_sync.Services.Script;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Init
{
    public class InitManager
    {
        readonly ScriptManager scr;
        readonly IAppConfig conf;
        public InitManager(IOptions<IAppConfig> conf)
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
