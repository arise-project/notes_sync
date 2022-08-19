using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;

namespace notes_sync.Services.Structure
{
	public class NoteCorrector : INoteCorrector
	{
		IAppConfig conf;
		public NoteCorrector(IAppConfig conf)
		{
			this.conf = conf;
		}

		public void NewLineForSentence(NoteFile nf)
		{
			
		}
	}
}
