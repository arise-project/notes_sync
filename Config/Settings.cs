
using notes_sync.Model;
using YamlDotNet.Serialization;

namespace notes_sync.Config
{
    //Zuzana 2
    public class Settings
    {
        [YamlMember(Alias = "text-note-pattern", ApplyNamingConventions = false)]
        public PatternMatch TextNotePattern {get;set;}
    }
}
