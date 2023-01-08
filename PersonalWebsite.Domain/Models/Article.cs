using PersonalWebsite.Domain.Enums;

namespace PersonalWebsite.Domain.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Thumbnail { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ArticleStatusType ArticleStatus { get; set; }
        public User Author { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<ArticleTag> Tags { get; set; }
    }
}