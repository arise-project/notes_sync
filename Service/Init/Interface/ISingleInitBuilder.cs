using notes_sync.Model;

namespace notes_sync.Services.Init.Interface
{
	public interface ISingleInitBuilder
	{
		bool SetProject(Project p);
		bool SetFrameworkFolder(FrameworkFolder ff);
		bool AddFramework(Framework f);
		bool AddPackageFolder(PackageFolder pf);
		bool Build(SdFolder sf);
	}	
}
