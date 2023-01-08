using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Domain.Models
{
    public class ArticleTag
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IList<Article> Articles { get; set; }
    }
}
