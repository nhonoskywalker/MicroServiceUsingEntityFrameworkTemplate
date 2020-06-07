namespace BusinessCard.Data
{
    using BusinessCard.Data.Entities.Badges;
    using BusinessCard.Data.Entities.Users;
    using BusinessCard.Insfrastructure.Data;
    using BusinessCard.Insfrastructure.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System;

    public class ApplicationDbContext : IdentityDbContext<
        UserEntity, RoleEntity, Guid, UserClaimEntity, UserRoleEntity, UserLoginEntity, RoleClaimEntity, UserTokenEntity>, 
        IAppDbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<BadgeEntity> Badges { get; set; }

        public DbSet<BusinessCardEntity> BusinessCards { get; set; }
      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserEntity>(entity =>
            {
                entity.ToTable(name: "Users");
                entity.HasKey(c => c.Id);
            });

            builder.Entity<RoleEntity>(entity =>
            {
                entity.ToTable(name: "Roles");
                entity.HasKey(c => c.Id);
            });

            builder.Entity<UserRoleEntity>(entity =>
            {
                entity.ToTable(name: "UserRoles");
                entity.HasKey(c => c.UserId);
            });

            builder.Entity<UserClaimEntity>(entity =>
            {
                entity.ToTable(name: "UserClaims");
                entity.HasKey(c => c.UserId);
            });

            builder.Entity<RoleClaimEntity>(entity =>
            {
                entity.ToTable(name: "RoleClaims");
                entity.HasKey(c => c.RoleId);
            });

            builder.Entity<UserLoginEntity>(entity =>
            {
                entity.ToTable(name: "UserLogins");
                entity.HasKey(c => c.UserId);
            });

            builder.Entity<UserTokenEntity>(entity =>
            {
                entity.ToTable(name: "UserTokens");
                entity.HasKey(c => c.UserId);
            });

            builder.Entity<BusinessCardEntity>(entity =>
            {
                entity.ToTable("BusinessCards");
                entity.HasKey(c => c.Id);
            });
        }
    }
}
