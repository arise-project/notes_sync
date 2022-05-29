namespace notes_sync_test.Services.Interface
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
