using System;

public class DockerCommandExecutor
{
    private SshClientManager sshClientManager;

    public DockerCommandExecutor(SshClientManager sshClientManager)
    {
        this.sshClientManager = sshClientManager;
    }

    public string SendDockerCommand(string dockerCommand)
    {
        var client = sshClientManager.GetClient();
        var cmd = client.CreateCommand("docker " + dockerCommand);
        var result = cmd.Execute();
        Console.WriteLine("Risultato del comando: " + result);
        return result;
    }
}
