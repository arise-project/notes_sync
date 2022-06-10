using notes_sync.Services.Init.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Init
{
	public class SingleInitBuilder : ISingleInitBuilder
	{
		public bool SetProject(Project p)
		{
			return false;
		}
		
		public bool SetFrameworkFolder(FrameworkFolder ff)
		{
			return false;
		}
		
		public bool AddFramework(Framework f)
		{
			return false;
		}
		
		public bool AddPackageFolder(PackageFolder pf)
		{
			return false;
		}
		
		public bool Build(SdFolder sf)
		{
			return false;
		}
	}	
}
