using notes_sync.Model;

namespace notes_sync.Services.Clean.Interface
{
    public interface ICompressManager
    {
        bool DuplicatesToDelimiter(TextFile tf);
    }
}
