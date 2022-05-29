using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class CapacityManager : ICapacityManager
	{
		FolderCapacity Calculate(SdFolder sf);
	}	
}
