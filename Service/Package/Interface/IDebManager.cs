using notes_sync.Model;

namespace notes_sync.Services.Package.Interface
{
    public interface IDebManager
    {
        PackageFolder Find(PackageModel p);
    }
}
