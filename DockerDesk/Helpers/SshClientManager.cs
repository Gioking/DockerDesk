using Renci.SshNet;

public class SshClientManager
{
    private string host;
    private string username;
    private string pathToPrivateKey;
    private int port;

    public SshClientManager(string host, string username, string pathToPrivateKey, int port = 22) // Porta default è 22
    {
        this.host = host;
        this.username = username;
        this.pathToPrivateKey = pathToPrivateKey;
        this.port = port;
    }

    public SshClient CreateSshClient()
    {
        var keyFile = new PrivateKeyFile(pathToPrivateKey);
        var keyFiles = new[] { keyFile };
        var methods = new AuthenticationMethod[] { new PrivateKeyAuthenticationMethod(username, keyFiles) };
        var connectionInfo = new ConnectionInfo(host, port, username, methods);

        return new SshClient(connectionInfo);
    }
}
