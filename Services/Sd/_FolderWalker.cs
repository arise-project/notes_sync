using notes_sync_test.Services.Sd.Interface;

namespace notes_sync_test.Services.Sd
{
	public class FolderWalker : IFolderWalker
	{
		public List<FileModel> Walk(string folder)
		{
			List<FileModel> list = new List<FileModel>();
			
			var files = Directory.GetFiles(folder, "*", SearchOption.TopDirectoryOnly);
			
			list.AddRange(files
				.Select(f => new FileModel(f, "", File.ReadAllText(f))));
			
			return list;
		}
	}	
}
