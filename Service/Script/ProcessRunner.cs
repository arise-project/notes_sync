using System.Diagnostics;
using notes_sync.Services.Script.Interface;
using notes_sync.Config;
using notes_sync.Model;

using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Script
{
    public class ProcessRunner : IProcessRunner
    {
        readonly AppConfig conf;
        public ProcessRunner(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public ProcessOutputModel Run(ProcessModel pm)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(pm.Command, pm.Arguments)
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            p.Start();
            p.WaitForExit();

            return new ProcessOutputModel
            {
                StdOut = p.StandardOutput.ReadToEnd(),
                StdErr = p.StandardError.ReadToEnd()
            };
        }
    }
}
