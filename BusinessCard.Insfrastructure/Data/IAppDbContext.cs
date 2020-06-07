namespace BusinessCard.Insfrastructure.Data
{
    using BusinessCard.Data.Entities.Badges;
    using BusinessCard.Insfrastructure.Entities;
    using Microsoft.EntityFrameworkCore;

    public interface IAppDbContext
    {
        public DbSet<BadgeEntity> Badges { get; set; }

        public DbSet<BusinessCardEntity> BusinessCards { get; set; }
    }
}
