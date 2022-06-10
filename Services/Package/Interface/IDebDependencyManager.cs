namespace notes_sync_test.Services.Package.Interface
{
	public interface IDebDependencyManager
	{
		List<Package> FindDependancies(Package p);
		List<Package> DownloadDependancies(Package p, PackageFolder pf);
		bool FixDependencies();
	}	
}
