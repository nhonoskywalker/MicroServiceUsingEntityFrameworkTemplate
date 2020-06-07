namespace BusinessCard.Insfrastructure.Messages.Badges
{
    using BusinessCard.Infrastructure.Messages;
    using BusinessCard.Insfrastructure.Entities;
    using BusinessCard.Insfrastructure.Models.Badges;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetBadgeByIdResponse : Response
    {
        [DataMember]
        public BadgeModel Data { get; set; }
    }
}
