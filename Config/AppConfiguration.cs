using notes_sync_test.Model;
 
namespace notes_sync_test.Config
{
	//Zuzana 2
	public class AppConfiguration
	{
		public string MountpointRoot { get; set; }
		ProcessModel MountCommand { get; set; }
		ProcessModel CapacityCommand { get; set; }
		ProcessModel ScriptCommand { get; set; }
	}
}
