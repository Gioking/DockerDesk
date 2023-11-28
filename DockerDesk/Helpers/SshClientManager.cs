using Renci.SshNet;
using System;

public class SshClientManager
{
    private string host;
    private string username;
    private string pathToPrivateKey;
    private int port;
    private SshClient client;

    public SshClientManager(string host, string username, string pathToPrivateKey, int port = 22)
    {
        this.host = host;
        this.username = username;
        this.pathToPrivateKey = pathToPrivateKey;
        this.port = port;
        this.client = null;
    }

    public void Connect()
    {
        var keyFile = new PrivateKeyFile(pathToPrivateKey);
        var connectionInfo = new ConnectionInfo(host, port, username,
            new AuthenticationMethod[] {
                new PrivateKeyAuthenticationMethod(username, new[] { keyFile })
            });

        this.client = new SshClient(connectionInfo);
        this.client.Connect();
    }

    public SshClient GetClient()
    {
        if (this.client == null || !this.client.IsConnected)
        {
            throw new InvalidOperationException("SSH client is not connected.");
        }

        return this.client;
    }

    public void Disconnect()
    {
        if (this.client != null && this.client.IsConnected)
        {
            this.client.Disconnect();
        }
    }

    public void Dispose()
    {
        if (this.client != null)
        {
            this.client.Dispose();
        }
    }
}
