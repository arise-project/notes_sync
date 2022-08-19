using notes_sync.Model;
 
namespace notes_sync.Config.Interface
{
	//Zuzana 2
	public interface IAppConfig
	{
		string MountPointRoot { get; set; }
		ProcessModel MountCommand { get; set; }
		ProcessModel CapacityCommand { get; set; }
		ProcessModel ScriptCommand { get; set; }
		ProcessModel PackageShowCommand { get; set; }
	}
}
