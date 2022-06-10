namespace notes_sync_test.Model
{
	public class ProcessOutputModel
	{
		public string StdOut {get;set;}
		public string StdErr {get;set;}
		public bool Ok => string.IsNullOrEmpty(StdErr);
	}	
}
