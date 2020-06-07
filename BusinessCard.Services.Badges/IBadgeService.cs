namespace BusinessCard.Services.Badges
{
    using BusinessCard.Insfrastructure.Messages.Badges;
    using System.Threading.Tasks;

    public interface IBadgeService
    {
        Task<GetBadgesResponse> GetBadges(GetBadgesRequest request);

        Task<GetBadgeByIdResponse> GetBadgeById(GetBadgeByIdRequest request);
    }
}
