using PersonalSite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalSite.DataAccess
{
    public class InMemoryBlogDataAccess : IBlogDataAccess
    {
        public IEnumerable<BlogSummary> GetLatestBlogsSummary()
        {
            return new List<BlogSummary>
            {
                new BlogSummary { BlogId = 5, BlogTitle = "Welcome to the Blog!", BlogPageLink = "/Blog/WelcomeToTheBlog", PublishDate = new DateTime(2020, 6, 10) },
                new BlogSummary { BlogId = 4, BlogTitle = "In Memory Data", BlogPageLink = "/Blog/InMemoryData", PublishDate = new DateTime(2020, 6, 11) },
                new BlogSummary { BlogId = 3, BlogTitle = "Patience is Key", BlogPageLink = "/Blog/PatienceIsKey", PublishDate = new DateTime(2020, 6, 13) },
                new BlogSummary { BlogId = 2, BlogTitle = "FizzBuzz - The Interview", BlogPageLink = "/Blog/FizzBuzz", PublishDate = new DateTime(2020, 6, 15) },
                new BlogSummary { BlogId = 1, BlogTitle = "Leadership vs Management", BlogPageLink = "/Blog/LeaderVsManager", PublishDate = new DateTime(2020, 6, 18) }
            }.OrderByDescending(r => r.PublishDate);
        }
    }
}
