using notes_sync.Services.Clean.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Clean
{
    public class Eraser : IEraser
    {
        readonly AppConfig conf;
        public Eraser(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }

        public bool Remove(NoteFile nf, Paragraph p)
        {
            return false;
        }

        public bool ReplaceFolder(TextFolder scr, TextFolder dest)
        {
            return false;
        }

        public bool ReplaceFolder(NoteFolder src, TextFolder dest)
        {
            return false;
        }
    }
}
