using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Application.Queries;

namespace PersonalWebsite.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArticlesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetArticleByArticleId([FromQuery]GetArticleByArticleIdQuery request)
        {
            var article = await _mediator.Send(request);
            return Ok(article);
        }
    }
}
