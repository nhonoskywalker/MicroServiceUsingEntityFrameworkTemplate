namespace BusinessCard.Extensions
{
    using BusinessCard.Messages;
    using Microsoft.AspNetCore.Mvc;

    public static class ControllerExtensions
    {
        public static IActionResult CreateResponse<T>(this ControllerBase controller, T value) where T : WebResponse
        {
            var result = default(IActionResult);
            result = value.IsSuccessful ? (IActionResult)new OkObjectResult(value) : new BadRequestObjectResult(value);
            return result;
        }
    }
}
