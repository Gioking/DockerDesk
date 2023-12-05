using DockerDesk.Helpers;
using NLog;
using System.Threading.Tasks;

public class DockerCommandExecutor
{
    private SshClientManager sshClientManager;
    private static Logger logger = LogManager.GetLogger("RemoteCommandLogger");

    public DockerCommandExecutor(SshClientManager sshClientManager)
    {
        this.sshClientManager = sshClientManager;
    }

    public async Task<string> SendDockerCommandAsync(string dockerCommand)
    {
        var client = sshClientManager.GetClient();
        var cmd = client.CreateCommand($"docker {dockerCommand}");

        var result = await Task.Run(() => cmd.Execute());

        var textwithnospace = StringUtility.NormalizeDockerOutput(result);

        logger.Info($"> host:{client.ConnectionInfo.Host}:{client.ConnectionInfo.Port} > command: {cmd.CommandText}");
        logger.Info($"Result:{textwithnospace}");
        logger.Info($"END ---");


        return result;
    }
}

