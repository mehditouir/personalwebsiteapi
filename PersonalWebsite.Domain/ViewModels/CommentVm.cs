using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Domain.ViewModels
{
    public class CommentVm
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Body { get; set; }
        public UserVm Author { get; set; }
    }
}
