using Microsoft.AspNetCore.Mvc;
using System.Collections.Specialized;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        /// <summary>
        /// Send message to Pushover
        /// </summary>
        /// <param name="messageRequest">Message request</param>
        [HttpPost]
        public void Post([FromBody] MessageRequest messageRequest)
        {
            var parameters = new NameValueCollection {
                { "token", messageRequest.AppToken },
                { "user", messageRequest.UserKey },
                { "message", messageRequest.Text }
            };

            using (var client = new WebClient())
            {
                client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
            }
        }
    }
}
