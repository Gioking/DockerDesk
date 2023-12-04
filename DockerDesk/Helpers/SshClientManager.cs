using Renci.SshNet;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SshClientManager
{
    private string host;
    private string username;
    private string password;
    private string pathToPrivateKey;
    private int port;
    private SshClient client;
    public delegate void ProgressChangedHandler(int percentage);
    public event ProgressChangedHandler ProgressChanged;

    public SshClientManager(string host, string username, string password, string pathToPrivateKey, int port = 22)
    {
        this.host = host;
        this.username = username;
        this.password = password;
        this.pathToPrivateKey = pathToPrivateKey;
        this.port = port;
        this.client = null;
    }

    public async Task ConnectAsync()
    {
        try
        {
            AuthenticationMethod[] authenticationMethods;
            if (!string.IsNullOrEmpty(password))
            {
                authenticationMethods = new AuthenticationMethod[] { new PasswordAuthenticationMethod(username, password) };
            }
            else if (!string.IsNullOrEmpty(pathToPrivateKey))
            {
                var keyFile = new PrivateKeyFile(pathToPrivateKey);
                authenticationMethods = new AuthenticationMethod[] { new PrivateKeyAuthenticationMethod(username, new[] { keyFile }) };
            }
            else
            {
                throw new InvalidOperationException("No valid authentication method provided.");
            }

            var connectionInfo = new ConnectionInfo(host, port, username, authenticationMethods);

            this.client = new SshClient(connectionInfo);

            // Esegui la connessione in un task separato
            await Task.Run(() => this.client.Connect());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to connect: {ex.Message}");
            Console.WriteLine($"Failed to connect: {ex.Message}");
        }
    }


    public SshClient GetClient()
    {
        if (this.client == null || !this.client.IsConnected)
        {
            throw new InvalidOperationException("SSH client is not connected.");
        }

        return this.client;
    }

    public bool DisconnectAndDispose()
    {
        if (this.client != null)
        {
            if (this.client.IsConnected)
            {
                this.client.Disconnect();
            }

            this.client.Dispose();
            this.client = null;
            return true;
        }
        return false;
    }

    public async Task<string> UploadAndDecompressFileAsync(string localFilePath, string remoteFilePath, string remoteExtractionPath)
    {
        if (this.client == null || !this.client.IsConnected)
        {
            throw new InvalidOperationException("SSH client is not connected.");
        }

        string commandResult = "";
        using (var sftpClient = new SftpClient(this.client.ConnectionInfo))
        {
            try
            {
                // Elimina il file ZIP esistente
                using (var sshClient = new SshClient(this.client.ConnectionInfo))
                {
                    sshClient.Connect();
                    var deleteCommand = sshClient.CreateCommand($"rm -f {remoteFilePath}");
                    deleteCommand.Execute();
                    sshClient.Disconnect();
                }

                // Carica il file via SFTP
                sftpClient.Connect();
                using (var fileStream = new FileStream(localFilePath, FileMode.Open))
                {
                    await Task.Run(() => sftpClient.UploadFile(fileStream, remoteFilePath));
                }
                sftpClient.Disconnect();

                // Decomprimi il file via SSH
                using (var sshClient = new SshClient(this.client.ConnectionInfo))
                {
                    sshClient.Connect();
                    var unzipCommand = sshClient.CreateCommand($"unzip -o {remoteFilePath} -d {remoteExtractionPath}");
                    await Task.Run(() => unzipCommand.Execute());
                    commandResult = unzipCommand.Result;

                    // Controlla il codice di uscita per determinare se c'è stato un errore
                    if (unzipCommand.ExitStatus != 0)
                    {
                        commandResult = $"Errore durante la decompressione: {commandResult}";
                    }

                    sshClient.Disconnect();
                }
            }
            catch (Exception ex)
            {
                commandResult = $"Errore durante il trasferimento e la decompressione del file: {ex.Message}";
            }
        }

        return commandResult;
    }

}
