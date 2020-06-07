namespace BusinessCard.Services.Badges.Repository
{
    using BusinessCard.Insfrastructure.Models.Badges;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBadgesRepository
    {
        Task<IEnumerable<BadgeModel>> GetBadges();

        Task<BadgeModel> GetBadgeById(Guid id);
    }
}
