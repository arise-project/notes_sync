using System;
using System.Linq;
using System.Collections.Generic;
using notes_sync.Services.Script.Interface;
using notes_sync.Config;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;

namespace notes_sync.Services.Script
{
    public class ScriptManager : IScriptManager
    {
        readonly ProcessRunner pr;

        readonly IAppConfig conf;

        public ScriptManager(IOptions<IAppConfig> conf, ProcessRunner pr)
        {
            this.conf = conf.Value;
            this.pr = pr;
        }

        public bool Run(ScriptModel sm)
        {
            sm.Init(conf);
            var pom = pr.Run(sm);
            return pom.Ok;
        }

        public List<string[]> ParseCsvStdOut(string so)
        {
            var ls = so.Replace(Environment.NewLine, "л").Split('л');
            return ls.Select(l => l.Split('\t')).ToList();
        }
    }
}
