using System.Collections.Generic;

namespace notes_sync.Model
{
    public class StructureModel
    {
        public SdFolder Root { get; set; }
        public BackupFolder Backup { get; set; }
        public NoteFolder Notes { get; set; }
        public FrameworkFolder Frameworks { get; set; }
        public List<RepoFolder> Repos { get; set; }
        public List<TextFolder> Texts { get; set; }
        public List<PackageFolder> Packages { get; set; }
    }
}
