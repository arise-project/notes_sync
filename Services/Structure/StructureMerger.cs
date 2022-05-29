using notes_sync_test.Services.Interface;

namespace notes_sync_test.Services
{
	public class StructureMerger : IStructureMerger
	{
		bool Init(SdFolder sf, Structure s);
		bool Update(SdFolder sf);
		bool Erase(SdFolder sf);
		bool Archive(SdFolder sf);
		bool Compress(SdFolder sf);
		bool RunScenario(Scenario s, SdFolder sf);
	}	
}
