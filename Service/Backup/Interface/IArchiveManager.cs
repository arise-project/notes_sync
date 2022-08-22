using notes_sync.Model;

namespace notes_sync.Services.Backup.Interface
{
    public interface IArchiveManager
    {
        bool Zip(FolderModel src, FolderModel dest, string name);
        bool ZipDiff(FolderModel src, FolderModel dest, string name);
    }
}
