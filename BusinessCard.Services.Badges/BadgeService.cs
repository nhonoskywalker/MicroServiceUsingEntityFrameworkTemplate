namespace BusinessCard.Services.Badges
{
    using BusinessCard.Insfrastructure.Messages.Badges;
    using BusinessCard.Services.Badges.Repository;
    using System.Threading.Tasks;

    public class BadgeService : IBadgeService
    {
        private readonly IBadgesRepository badgesRepository;

        public BadgeService(IBadgesRepository badgesRepository)
        {
            this.badgesRepository = badgesRepository;
        }

        public async Task<GetBadgeByIdResponse> GetBadgeById(GetBadgeByIdRequest request)
        {
            var result = new GetBadgeByIdResponse()
            {
                Data = await this.badgesRepository.GetBadgeById(request.Id)
            };

            return result;
        }

      
        public async Task<GetBadgesResponse> GetBadges(GetBadgesRequest request)
        {
            var result = new GetBadgesResponse
            {
                Data = await this.badgesRepository.GetBadges()
            };

            return result;
        }
    }
}
