using Newtonsoft.Json;

namespace DockerDesk.Models
{
    public class RootObject
    {
        [JsonProperty("c.nginx")]
        public ContainerConfig CNginx { get; set; }
    }
}
