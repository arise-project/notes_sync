using System.IO;

namespace notes_sync.Model
{
    //M109A3
    public class FileModel
    {
        public FileModel()
        {

        }

        public FileModel(string fullName, string folder, string text)
        {
            Name = Path.GetFileNameWithoutExtension(fullName);
            FullName = fullName;
            Namespace = folder;
            Text = text;
            Empty = string.IsNullOrWhiteSpace(text);
        }

        public string Name { get; set; }

        public string FullName { get; set; }

        public string Namespace { get; set; }

        public string Text { get; set; }

        public bool Empty { get; set; }
    }
}
