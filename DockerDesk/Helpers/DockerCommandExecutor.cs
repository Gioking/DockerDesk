using System;
using System.Threading.Tasks;

public class DockerCommandExecutor
{
    private SshClientManager sshClientManager;

    public DockerCommandExecutor(SshClientManager sshClientManager)
    {
        this.sshClientManager = sshClientManager;
    }

    public async Task<string> SendDockerCommandAsync(string dockerCommand)
    {
        var client = sshClientManager.GetClient();
        var cmd = client.CreateCommand("docker " + dockerCommand);
        var result = await Task.Run(() => cmd.Execute());
        Console.WriteLine("Risultato del comando: " + result);
        return result;
    }
}

