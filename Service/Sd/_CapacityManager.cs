using System.Linq;
using System.Collections.Generic;
using notes_sync.Services.Sd.Interface;
using notes_sync.Services.Script;
using notes_sync.Config;
using notes_sync.Model;

namespace notes_sync.Services.Sd
{
	public class CapacityManager : ICapacityManager
	{
		AppConfiguration ac;
		ProcessRunner pr;
		ScriptManager sm;
		
		public CapacityManager(AppConfiguration ac, ProcessRunner pr, ScriptManager sm)
		{
			this.ac = ac;
			this.pr = pr;
			this.sm = sm;
		}
		
		// df -P -BM
		public List<SdCapacity> List(List<SdFolder> sfs)
		{
			// /media/galliumos/182E-D5FE
			var pom = pr.Run(ac.MountCommand);
			
			if(!pom.Ok)
			{
				return new List<SdCapacity>(); 
			}
			
			var csv = sm.ParseCsvStdOut(pom.StdOut);
			
			///dev/sdc1               1881M 1819M       63M      97% /media/galliumos/182E-D5FE

			return csv.Where(l => l.Skip(5).FirstOrDefault()?.StartWith(ac.MountPointRoot) == true)
				.Select(l => new SdCapacity 
					{ 
						Sd = sfs.FirstOrDefault(sf => sf.Root == l.Skip(5).First()),
						Cur = int.Parse((l.Skip(3).FirstOrDefault() ?? "0").TrimEnd("M")) 
					})
				.ToList();
		}
	}	
}
