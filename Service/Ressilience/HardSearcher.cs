using notes_sync.Services.Ressillence.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Ressillence
{
	public class HardSearcher : IHardSearcher
	{
		IAppConfig conf;
		public HardSearcher(IAppConfig conf)
		{
			this.conf = conf;
		}

		public TextFile Find(TextFile tf)
		{
			return null;
		}

		public NoteFile Find(NoteFile nf)
		{
			return null;
		}
	}
}
