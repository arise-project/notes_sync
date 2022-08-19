using notes_sync.Services.Backup.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Backup
{
	public class ArchiveManager : IArchiveManager
	{
		IAppConfig conf;
		public ArchiveManager(IAppConfig conf)
		{
			this.conf = conf;
		}
		
		public bool Zip(FolderModel src, FolderModel dest, string name)
		{
			return false;
		}

		public bool ZipDiff(FolderModel src, FolderModel dest, string name)
		{
			return false;
		}
 	}
}
