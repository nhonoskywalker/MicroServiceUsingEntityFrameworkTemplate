namespace BusinessCard.Messages.Badges
{
    using BusinessCard.Insfrastructure.Models.Badges;
    using Newtonsoft.Json;

    public class GetBadgeByIdWebResponse : WebResponse
    {
        [JsonProperty("data")]
        public BadgeModel Data { get; set; }
    }
}
