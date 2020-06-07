namespace BusinessCard.Services.Badges.Extensions
{
    using BusinessCard.Data.Entities.Badges;
    using BusinessCard.Insfrastructure.Models.Badges;
    using System.Collections.Generic;
    using System.Linq;

    public static class BadgesExtensions
    {
        public static IEnumerable<BadgeModel> AsModel(this IEnumerable<BadgeEntity> entities)
        {
            var result = entities.Select(entity => entity.AsModel());

            return result;
        }

        public static BadgeModel AsModel(this BadgeEntity entity)
        {
            var result = new BadgeModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price
            };

            return result;
        }
    }
}
