using MediatR;
using PersonalWebsite.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Application.Queries
{
    public class GetArticleByArticleIdQuery : IRequest<ArticleResult>
    {
        public Guid Id { get; set; }
    }
}
