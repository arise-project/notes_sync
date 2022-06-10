using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Script.Interface
{
	public interface IScriptManager
	{
		bool Run(ScriptModel sm);
	}	
}
