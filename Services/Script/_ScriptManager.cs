using notes_sync_test.Services.Script.Interface;

namespace notes_sync_test.Services.Script
{
	public class ScriptManager : IScriptManager
	{
		AppConfiguration ac;
		ProcessRunner pr;
		
		pubclic ScriptManager(AppConfiguration ac, ProcessRunner pr)
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
