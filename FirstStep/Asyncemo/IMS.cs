using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SDListDemo
{
     public partial class IMS
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }
        [JsonProperty("creator")]
        public string Creator { get; set; }
        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }
        [JsonProperty("members")]
        public List<string> Members { get; set; }

    }
}
