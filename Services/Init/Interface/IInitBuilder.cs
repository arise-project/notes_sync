namespace notes_sync_test.Services.Init.Interface
{
	public interface IInitBuilder
	{
		bool SetFrameworkFolder(FrameworkFolder ff);
		bool AddFramework(Framework f);
		bool AddPackageFolder(PackageFolder pf);
		bool Build(SdFolder sf);
	}	
}