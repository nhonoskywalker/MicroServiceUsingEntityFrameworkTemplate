namespace BusinessCard.Messages.Badges
{
    using Newtonsoft.Json;
    using System;

    public class GetBadgeByIdWebRequest
    {
        [JsonRequired]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
