using notes_sync.Services.Init.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Init
{
	public class InitBuilder : IInitBuilder
	{
		IAppConfig conf;
		public InitBuilder(IAppConfig conf)
		{
			this.conf = conf;
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
