using Newtonsoft.Json;

namespace MemeGenerator
{
    public class Payload
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
