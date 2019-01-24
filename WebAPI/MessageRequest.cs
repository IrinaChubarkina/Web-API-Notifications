namespace WebAPI.Controllers
{
    public class MessageRequest
    {
        /// <summary>
        /// Text you want to send
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// User key
        /// </summary>
        public string UserKey { get; set; }
        /// <summary>
        /// App token
        /// </summary>
        public string AppToken { get; set; }
    }
}
