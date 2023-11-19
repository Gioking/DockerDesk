using Newtonsoft.Json;
using System.Collections.Generic;

public class DockerJsonContainer
{
    [JsonProperty("EnvVariable")]
    public List<DockerJsonVariable> EnvVariables { get; set; }
}
