using Newtonsoft.Json;

public class DockerJsonVariable
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}
