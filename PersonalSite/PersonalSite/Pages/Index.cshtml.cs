using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PersonalSite.DataAccess;
using PersonalSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBlogDataAccess blogDataAccess;
        private readonly IAppsDataAccess appsDataAccess;
        private readonly DateTime codingStartDate;

        public int CodingYears { get; set; }
        public IEnumerable<BlogSummary> LatestBlogs { get; set; }
        public IEnumerable<AppsSummary> LatestApps { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBlogDataAccess blogDataAccess, IAppsDataAccess appsDataAccess)
        {
            _logger = logger;
            this.blogDataAccess = blogDataAccess;
            this.appsDataAccess = appsDataAccess;
            codingStartDate = new DateTime(2012, 12, 12);
        }

        public void OnGet()
        {
            CodingYears = DateTime.UtcNow.Year - codingStartDate.Year;
            LatestBlogs = blogDataAccess.GetLatestBlogsSummary();
            LatestApps = appsDataAccess.GetLatestApps();
        }
    }
}
