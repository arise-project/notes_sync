using notes_sync.Model;

namespace notes_sync.Services.Script.Interface
{
    public interface IProcessRunner
    {
        ProcessOutputModel Run(ProcessModel pm);
    }
}
