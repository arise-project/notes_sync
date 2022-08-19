using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
	public class SensitiveFileUnit : IUnit<SensitiveFile>
	{
		IAppConfig conf;
		public SensitiveFileUnit(IAppConfig conf)
		{
			this.conf = conf;
		}

		public bool Run(string [] args)
		{
			return false;
		}
	}
}
