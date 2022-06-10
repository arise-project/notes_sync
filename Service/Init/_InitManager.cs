using System.Collections.Generic;
using notes_sync.Services.Init.Interface;
using notes_sync.Services.Sd;
using notes_sync.Services.Script;
using notes_sync.Model;

namespace notes_sync.Services.Init
{
	public class InitManager
	{
		ScriptManager scr;
		
		public InitManager(ScriptManager scr)
		{
			this.scr = scr;	
		}
		
		public bool Run(List<SdFolder> sfs)
		{
			bool r = true;
			foreach(var sf in sfs)
			{
				//ScriptFile scf = fm.FullInit(sf);
				//r &= scr.Run(scf);
			}
			
			return r;
		}
	}	
}
