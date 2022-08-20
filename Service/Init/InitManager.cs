using System.Collections.Generic;
using notes_sync.Services.Init.Interface;
using notes_sync.Services.Sd;
using notes_sync.Services.Script;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Init
{
    public class InitManager
    {
        readonly ScriptManager scr;
        readonly IAppConfig conf;
        public InitManager(IAppConfig conf)
        {
            this.conf = conf;
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
