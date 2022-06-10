using notes_sync.Services.Backup.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Backup
{
	public class ArchiveManager : IArchiveManager
	{
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
