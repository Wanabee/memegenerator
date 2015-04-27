using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WanaBot
{
    class MemeGeneratorModel
    {
        [JsonProperty("")]
        public string Token { get; set; }

    }
}
