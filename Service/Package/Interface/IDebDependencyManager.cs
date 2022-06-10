using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Package.Interface
{
	public interface IDebDependencyManager
	{
		List<PackageModel> FindDependancies(PackageModel p);
		List<PackageModel> DownloadDependancies(PackageModel p, PackageFolder pf);
		bool FixDependencies();
	}	
}
