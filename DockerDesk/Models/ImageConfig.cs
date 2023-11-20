using Newtonsoft.Json;
using System.Collections.Generic;

namespace DockerDesk.Models
{
    public class ImageConfig
    {
        [JsonProperty("image_name")]
        public string ImageName { get; set; }

        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        [JsonProperty("EnvVariable")]
        public List<EnvVariable> EnvVariables { get; set; }
    }
}
