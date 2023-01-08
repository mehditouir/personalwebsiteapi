using PersonalWebsite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Domain.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Body { get; set; }
        public Comment ParentComment { get; set; }
        public CommentStatusType CommentStatus { get; set; }
    }
}
