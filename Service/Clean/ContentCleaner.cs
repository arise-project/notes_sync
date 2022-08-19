using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Clean
{
	public class ContentCleaner : IContentCleaner
	{
		IAppConfig conf;
		public ContentCleaner(IAppConfig conf)
		{
			this.conf = conf;
		}
	}
}
