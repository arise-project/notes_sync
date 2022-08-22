using notes_sync.Services.Structure.Interface;
using notes_sync.Model;
using notes_sync.Config.Interface;
using Microsoft.Extensions.Options;
using notes_sync.Config;

namespace notes_sync.Services.Structure
{
    public class ReportManager : IReportManager
    {
        AppConfig conf;
        public ReportManager(IOptions<AppConfig> conf)
        {
            this.conf = conf.Value;
        }
    }
}
