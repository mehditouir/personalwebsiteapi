using MediatR;
using PersonalWebsite.Application.Queries;
using PersonalWebsite.Application.Results;
using PersonalWebsite.Domain.Enums;
using PersonalWebsite.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWebsite.Application.Handlers
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByArticleIdQuery, ArticleResult>
    {
        public async Task<ArticleResult> Handle(GetArticleByArticleIdQuery request, CancellationToken cancellationToken)
        {
            return new ArticleResult
            {
                ArticleVm = new()
                {
                    Id = request.Id,
                    Title = "i'm a title",
                    Subtitle = "i'm a subtitle",
                    Body = "i'm a body",
                    CreatedOn = DateTime.UtcNow,
                    Thumbnail = "i'm a thumbnail",
                    Author = new()
                    {
                        Id = Guid.NewGuid(),
                        Email = "mehdi.touir.93@gmail.com",
                        FirstName = "Mehdi",
                        LastName = "Touir",
                        Biography = "i'm a bio",
                        UserRoles = new List<UserRoleType>()
                        {
                            UserRoleType.ADMIN,
                            UserRoleType.REGULAR
                        }
                    }
                }
            };
        }
    }
}
