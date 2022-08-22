using System;
using System.Collections.Generic;
using System.Linq;
using notes_sync.Services.Sd.Interface;
using notes_sync.Services.Script;
using notes_sync.Config;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Sd
{
    //FH70
    public class SdManager : ICapacityManager
    {
        ProcessRunner pr;
        readonly ScriptManager sm;
        readonly IAppConfig conf;
        public SdManager(IOptions<IAppConfig> conf, ProcessRunner pr, ScriptManager sm)
        {
            this.conf = conf.Value;
            this.pr = pr;
            this.sm = sm;
        }

        // mount		
        public List<SdFolder> List(List<SdFolder> sfs)
        {
            var pom = pr.Run(conf.MountCommand);

            if (!pom.Ok)
            {
                return new List<SdFolder>();
            }

            //Harpoon
            var csv = sm.ParseCsvStdOut(pom.StdOut);

            ///dev/sdc1 on /media/galliumos/182E-D5FE type vfat (rw,nosuid,nodev,relatime,uid=999,gid=999,fmask=0022,dmask=0022,codepage=437,iocharset=iso8859-1,shortname=mixed,showexec,utf8,flush,errors=remount-ro,uhelper=udisks2)

            return csv.Where(l => l.Skip(1).FirstOrDefault() == "on" && l.Skip(2).FirstOrDefault()?.IndexOf(conf.MountPointRoot) == 0)
                .Select(l => new SdFolder { Root = l.Skip(2).First() })
                .ToList();
        }
    }
}
