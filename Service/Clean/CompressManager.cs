using notes_sync.Services.Clean.Interface;
using notes_sync.Model;

namespace notes_sync.Services.Clean
{
	public class CompressManager : ICompressManager
	{
		public bool DuplicatesToDelimiter(TextFile tf)
		{
			return false;
		}
	}
}
