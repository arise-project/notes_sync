using System.Diagnostics;
using notes_sync.Services.Script.Interface;
using notes_sync.Config;
using notes_sync.Model;

namespace notes_sync.Services.Script
{
	public class ProcessRunner : IProcessRunner
	{
		public ProcessOutputModel Run(ProcessModel pm)
		{
			Process p = new Process();
	        p.StartInfo = new ProcessStartInfo(pm.Command, pm.Arguments ) {
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
