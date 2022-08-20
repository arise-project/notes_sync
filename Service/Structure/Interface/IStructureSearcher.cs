using notes_sync.Model;

namespace notes_sync.Services.Structure.Interface
{
    public interface IStructureSearcher
    {
        StructureModel Find(SdFolder sf);
    }
}
