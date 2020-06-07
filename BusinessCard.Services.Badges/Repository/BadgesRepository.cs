namespace BusinessCard.Services.Badges.Repository
{
    using BusinessCard.Insfrastructure.Data;
    using BusinessCard.Insfrastructure.Models.Badges;
    using BusinessCard.Services.Badges.Extensions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BadgesRepository : IBadgesRepository
    {
        private readonly IAppDbContext appDbContext;

        public BadgesRepository(IAppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<BadgeModel> GetBadgeById(Guid id)
        {
            var result = await this.appDbContext.Badges.FindAsync(id);

            return result.AsModel();
        }

        public async Task<IEnumerable<BadgeModel>> GetBadges()
        {
            var result = await this.appDbContext.Badges.ToListAsync();
               
            return result.AsModel();
        }
    }
}
