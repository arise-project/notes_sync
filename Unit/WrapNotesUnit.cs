using notes_sync.Config.Interface;
using notes_sync.Unit.Interface;

namespace notes_sync.Unit
{
    public class WrapNotesUnit : IUnit<WrapNotes>
	{
		IAppConfig conf;
		public WrapNotesUnit(IAppConfig conf)
		{
			this.conf = conf;
		}
		
		public bool Run(string [] args)
		{
			return false;
		}
	}
}
