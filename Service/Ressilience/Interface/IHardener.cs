using System.Collections.Generic;
using notes_sync.Model;

namespace notes_sync.Services.Ressillence.Interface
{
    public interface IHardener
    {
        List<TextFile> SetNames(TextFolder tf);
        List<NoteFile> SetNames(NoteFolder nf);
    }
}
