namespace BusinessCard.Insfrastructure.Messages.Badges
{
    using BusinessCard.Infrastructure.Messages;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class GetBadgeByIdRequest : Request
    {
        [DataMember]
        public Guid Id { get; set; }
    }
}
