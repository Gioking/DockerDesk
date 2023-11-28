﻿using Renci.SshNet;
using System;
using System.IO;
using System.Threading.Tasks;

public class SshClientManager
{
    private string host;
    private string username;
    private string pathToPrivateKey;
    private int port;
    private SshClient client;
    public delegate void ProgressChangedHandler(int percentage);
    public event ProgressChangedHandler ProgressChanged;

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

    protected virtual void OnProgressChanged(int percentage)
    {
        ProgressChanged?.Invoke(percentage);
    }

    public async Task UploadFilesViaScpAsync(string localDirectoryPath, string remoteDirectoryPath)
    {
        if (this.client == null || !this.client.IsConnected)
        {
            throw new InvalidOperationException("SSH client is not connected.");
        }

        using (var scpClient = new ScpClient(this.client.ConnectionInfo))
        {
            try
            {
                scpClient.Connect();
                var files = Directory.GetFiles(localDirectoryPath);
                int totalFiles = files.Length;
                int uploadedCount = 0;

                foreach (var file in files)
                {
                    var remoteFilePath = Path.Combine(remoteDirectoryPath, Path.GetFileName(file));
                    await Task.Run(() => scpClient.Upload(new FileInfo(file), remoteFilePath));

                    uploadedCount++;
                    int percentage = (int)((uploadedCount / (float)totalFiles) * 100);
                    OnProgressChanged(percentage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante il trasferimento file: {ex.Message}");
            }
            finally
            {
                if (scpClient.IsConnected)
                {
                    scpClient.Disconnect();
                }
            }
        }
    }


}
