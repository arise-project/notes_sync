using System;
using System.Collections.Generic;
using notes_sync.Services.Script.Interface;
using notes_sync.Config;
using notes_sync.Model;

namespace notes_sync.Services.Script
{
	public class ScriptManager : IScriptManager
	{
		AppConfiguration ac;
		ProcessRunner pr;
		
		public ScriptManager(AppConfiguration ac, ProcessRunner pr)
		{
			this.ac = ac;
			this.pr = pr;	
		}
		
		public bool Run(ScriptModel sm)
		{
			sm.Init(ac);
			var pom = pr.Run();
			return pom.Ok;
		}
		
		public List<string[]> ParseCsvStdOut(string so)
		{
			var ls = so.Replace(Environment.NewLine, "л").Split('л');
			return ls.Select(l => l.Split('\t')).ToList();
		}
	}
}
