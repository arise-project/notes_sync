using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Sd.Interface
{
	public interface ICapacityManager
	{
		List<SdCapacity> List(List<SdFolder> sfs);
	}	
}
