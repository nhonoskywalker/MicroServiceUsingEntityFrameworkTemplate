namespace BusinessCard.Controllers
{
    using BusinessCard.Extensions;
    using BusinessCard.Extensions.Messages;
    using BusinessCard.Messages.Badges;
    using BusinessCard.Services.Badges;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private readonly IBadgeService badgeService;

        public BadgesController(IBadgeService badgeService)
        {
            this.badgeService = badgeService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetBadgesAsync([FromQuery] GetBadgesWebRequest request)
        {
            var result = await this.badgeService.GetBadges(request.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBadgeByIdAsync([FromRoute] GetBadgeByIdWebRequest request)
        {
            var result = await this.badgeService.GetBadgeById(request.AsRequest());

            return this.CreateResponse(result.AsWebResponse());
        }
    }
}
