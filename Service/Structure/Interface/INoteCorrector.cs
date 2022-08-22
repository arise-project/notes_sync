using notes_sync.Model;

namespace notes_sync.Services.Structure.Interface
{
    public interface INoteCorrector
    {
        void NewLineForSentence(NoteFile nf);
    }
}
