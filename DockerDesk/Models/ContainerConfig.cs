using Newtonsoft.Json;
using System.Collections.Generic;

namespace DockerDesk.Models
{
    public class ContainerConfig
    {
        [JsonProperty("container_id")]
        public string ContainerId { get; set; }
        [JsonProperty("EnvVariable")]
        public List<EnvVariable> EnvVariables { get; set; }
    }
}
