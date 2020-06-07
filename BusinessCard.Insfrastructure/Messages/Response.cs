namespace BusinessCard.Infrastructure.Messages
{
    using BusinessCard.Infrastructure.Enums;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class Response
    {
        private string message;

        public Response()
        {
            this.Errors = new List<string>();
            this.StatusCode = (int)CustomStatusCode.Ok;
            this.IsSuccessful = true;
        }

        [DataMember]
        public bool IsSuccessful { get; protected set; }

        [DataMember]
        public ICollection<string> Errors { get; set; }

        [DataMember]
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

        [DataMember]
        public int StatusCode { get; set; }

        public void SetError(int statusCode)
        {
            this.StatusCode = statusCode;
            this.IsSuccessful = false;
        }
    }
}
