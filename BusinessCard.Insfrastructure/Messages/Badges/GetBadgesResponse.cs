namespace BusinessCard.Insfrastructure.Messages.Badges
{
    using BusinessCard.Infrastructure.Messages;
    using BusinessCard.Insfrastructure.Models.Badges;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetBadgesResponse : Response
    {
        [DataMember]
        public IEnumerable<BadgeModel> Data { get; set; }
    }
}
