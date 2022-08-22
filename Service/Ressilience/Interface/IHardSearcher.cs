using notes_sync.Model;

namespace notes_sync.Services.Ressillence.Interface
{
    public interface IHardSearcher
    {
        TextFile Find(TextFile tf);
        NoteFile Find(NoteFile nf);
    }
}
