using BusinessCard.Insfrastructure.Messages.Badges;
using BusinessCard.Messages.Badges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessCard.Extensions.Messages
{
    public static class BadgeMessagesExetentions
    {
        public static GetBadgesRequest AsRequest(this GetBadgesWebRequest webRequest)
        {
            var result = new GetBadgesRequest
            {

            };

            return result;
        }

        public static GetBadgesWebResponse AsWebResponse(this GetBadgesResponse response)
        {
            var result = new GetBadgesWebResponse
            { 
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }


        public static GetBadgeByIdRequest AsRequest(this GetBadgeByIdWebRequest webRequest)
        {
            var result = new GetBadgeByIdRequest
            {
                Id = webRequest.Id
            };

            return result;
        }

        public static GetBadgeByIdWebResponse AsWebResponse(this GetBadgeByIdResponse response)
        {
            var result = new GetBadgeByIdWebResponse
            {
                Errors = response.Errors,
                IsSuccessful = response.IsSuccessful,
                Message = response.Message,
                StatusCode = response.StatusCode,
                Data = response.Data
            };

            return result;
        }
    }
}
