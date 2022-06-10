using notes_sync_test.Services.Init.Interface;

namespace notes_sync_test.Services.Init
{
	public class InitManager
	{
		FolderManager fld;
		ScriptManager scr;
		
		public InitManager(FolderManager fld, ScriptManager scr)
		{
			this.fld = fld;
			this.scr = scr;	
		}
		
		public bool Run(List<SdFolder> sfs)
		{
			bool r = true;
			foreach(var sf in sfs)
			{
				ScriptFile scf = fm.FullInit(sf);
				r &= scr.Run(scf);
			}
			
			return r;
		}
	}	
}
