namespace notes_sync_test.Model
{
	public class ScritModel : ProcessModel
	{
		public void Init(AppConfiguration ac)
		{
			Command = ac.ScriptCommand;
		}
	}	
}
