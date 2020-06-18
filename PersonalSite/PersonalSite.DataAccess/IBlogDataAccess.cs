using PersonalSite.Entities;
using System.Collections.Generic;

namespace PersonalSite.DataAccess
{
    public interface IBlogDataAccess
    {
        public IEnumerable<BlogSummary> GetLatestBlogsSummary();
    }
}
