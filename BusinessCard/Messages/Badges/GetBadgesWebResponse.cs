namespace BusinessCard.Messages.Badges
{
    using BusinessCard.Insfrastructure.Models.Badges;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class GetBadgesWebResponse : WebResponse
    {
        [JsonProperty("data")]
        public IEnumerable<BadgeModel> Data { get; set; }
    }
}
