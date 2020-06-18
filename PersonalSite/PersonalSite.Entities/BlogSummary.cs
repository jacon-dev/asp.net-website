using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSite.Entities
{
    public class BlogSummary
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogPageLink { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
