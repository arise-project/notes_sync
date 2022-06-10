using System.Diagnostics;
using notes_sync_test.Services.Script.Interface;

namespace notes_sync_test.Services.Script
{
	public class ProcessRunner : IProcessRunner
	{
		public ProcessOutputModel Run(ProcessModel pm)
		{
			Process p = new Process();
	        p.StartInfo = new ProcessStartInfo(pm.Command, pm.Agruments ) {
	            UseShellExecute = false,
	            CreateNoWindow = true,
	            RedirectStandardOutput = true,
	            RedirectStandardError = true
	        };
	
	        p.Start();
	        p.WaitForExit();
	        
	        return new ProcessOutputModel{
	        	StdOut = p.StandardOutput.ReadToEnd(),
	        	StdErr = p.StandardError.ReadToEnd()	
	        };
		}
	}
}
