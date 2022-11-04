using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainWatchSystem.BLL;
using TrainWatchSystem.Entities;

namespace TrainWebApp.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly TrainWatchServices _trainWatchServices;
        public AboutModel(ILogger<IndexModel> logger, TrainWatchServices trainWatchServices)
        {
            _logger = logger;
            _trainWatchServices = trainWatchServices;
        }

        public DbVersion CurrentBuildVersion { get; set; } = null!;
        public void OnGet()
        {
            CurrentBuildVersion = _trainWatchServices.GetDbVersion();
        }
    }
}
