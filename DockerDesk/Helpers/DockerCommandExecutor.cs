using System;

public class DockerCommandExecutor
{
    private SshClientManager sshClientManager;

    public DockerCommandExecutor(SshClientManager sshClientManager)
    {
        this.sshClientManager = sshClientManager;
    }

    public void SendDockerCommand(string dockerCommand)
    {
        using (var client = sshClientManager.CreateSshClient())
        {
            try
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var cmd = client.CreateCommand("docker " + dockerCommand);
                    var result = cmd.Execute();
                    Console.WriteLine("Risultato del comando: " + result);
                }
                else
                {
                    Console.WriteLine("Connessione SSH non riuscita.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore: " + ex.Message);
            }
            finally
            {
                if (client.IsConnected)
                {
                    client.Disconnect();
                }
            }
        }
    }
}
