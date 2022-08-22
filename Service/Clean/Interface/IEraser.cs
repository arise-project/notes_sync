using notes_sync.Model;

namespace notes_sync.Services.Clean.Interface
{
    public interface IEraser
    {
        bool Remove(NoteFile nf, Paragraph p);
        bool ReplaceFolder(TextFolder src, TextFolder dest);
        bool ReplaceFolder(NoteFolder src, TextFolder dest);
    }
}
