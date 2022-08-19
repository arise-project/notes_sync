namespace notes_sync.Model
{
	public class SdFolder : FolderModel
	{
		public SdFolder(string name, string fullName) : base(name, fullName)
		{
		}

		public string Root {get;set;}
	}	
}
