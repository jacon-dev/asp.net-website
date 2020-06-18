using PersonalSite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.DataAccess
{
    public interface IAppsDataAccess
    {
        public IEnumerable<AppsSummary> GetLatestApps();
    }
}
