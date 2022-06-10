using System.Collections.Generic;
using notes_sync.Services.Package.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Package
{
	public class DebDependencyManager : IDebDependencyManager
	{
		public List<PackageModel> FindDependancies(PackageModel p)
		{
			return null;
		}

		public List<PackageModel> DownloadDependancies(PackageModel p, PackageFolder pf)
		{
			return null;
		}

		public bool FixDependencies()
		{
			return false;
		}
	}
}
