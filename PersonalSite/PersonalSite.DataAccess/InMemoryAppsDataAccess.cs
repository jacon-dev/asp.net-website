using PersonalSite.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PersonalSite.DataAccess
{
    public class InMemoryAppsDataAccess : IAppsDataAccess
    {
        public IEnumerable<AppsSummary> GetLatestApps()
        {
            return new List<AppsSummary>
            {
                new AppsSummary { AppId = 1, AppName = "Skate Timer", AppPageLink = "/Apps/SkateTimer" }
            }.OrderByDescending(a => a.AppId);
        }
    }
}
