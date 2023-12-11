using Newtonsoft.Json;
using System.Collections.Generic;

public class DockerJsonContainer
{
    public string Name { get; set; }

    [JsonProperty("EnvVariable")]
    public List<DockerJsonVariable> EnvVariables { get; set; }
}
