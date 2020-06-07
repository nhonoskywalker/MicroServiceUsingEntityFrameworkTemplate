 namespace BusinessCard.Messages
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class WebResponse<T> : WebResponse
    {
        [JsonProperty("data")]
        public T Data { get; set; }
    }

    public class WebResponse
    {
        private string message;

        public WebResponse()
        {
            this.Errors = new List<string>();
            this.StatusCode = 0;
        }

        [JsonProperty("isSuccessful")]
        public bool IsSuccessful { get; set; }

        [JsonProperty("errors")]
        public ICollection<string> Errors { get; set; }

        [JsonProperty("message")]
        public string Message
        {
            get
            {
                return this.message ?? string.Join(string.Empty, this.Errors);
            }

            set
            {
                this.message = value;
            }
        }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }
}
