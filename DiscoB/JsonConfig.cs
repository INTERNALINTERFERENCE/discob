using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoB
{
    struct JsonConfig
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }

    }
}
