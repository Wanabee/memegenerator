using Newtonsoft.Json;

namespace MemeGenerator
{
    public class MemeGeneratorModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public Data Data;
        
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }

    public class Data
    {
            [JsonProperty("url")]
            public string Url { get; set; }

            [JsonProperty("page_url")]
            public string PageUrl { get; set; }
    }
}
