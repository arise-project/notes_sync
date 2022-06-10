using notes_sync_test.Services.Package.Interface;

namespace notes_sync_test.Services.Package
{
	public class DebDependencyManager : IDebDependencyManager
	{
		public List<Package> FindDependancies(Package p)
		{
		}

		public List<Package> DownloadDependancies(Package p, PackageFolder pf)
		{
		}

		public bool FixDependencies()
		{
		}
	}
}
