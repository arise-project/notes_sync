using notes_sync.Model;
 
namespace notes_sync.Config
{
	//Zuzana 2
	public class AppConfig
	{
		public string MountPointRoot { get; set; }
		public ProcessModel MountCommand { get; set; }
		public ProcessModel CapacityCommand { get; set; }
		public ProcessModel ScriptCommand { get; set; }
		public ProcessModel PackageShowCommand { get; set; }
		
	}
}
