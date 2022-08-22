namespace notes_sync.Model
{
    public class FolderModel
    {
        public FolderModel(string name, string fullName)
        {
            Name = name;
            FullName = fullName;
        }

        public string Name { get; set; }

        public string FullName { get; set; }
    }
}
