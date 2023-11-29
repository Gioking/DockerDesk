using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public class DockerNetWorkChecker
    {
        public static async Task<bool> IsNetworkRangeInUseAsync(string subnet, SshClientManager sshClientManager)
        {
            try
            {
                var client = sshClientManager.GetClient();

                if (client == null)
                {
                    MessageBox.Show("Please connect ssh client first.");
                    return false;
                }

                using (var sshClient = new SshClient(client.ConnectionInfo))
                {
                    sshClient.Connect();
                    var cmd = sshClient.CreateCommand("docker network ls --no-trunc --format '{{.Name}}' | xargs -I {} docker network inspect {} -f '{{range .IPAM.Config}}{{.Subnet}}{{end}}'");
                    var result = await Task.Run(() => cmd.Execute());

                    List<string> subnetList = new List<string>();
                    var subnets = result.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    sshClient.Disconnect();

                    foreach (string snat in subnets)
                    {
                        subnetList.Add(snat.Trim());
                    }

                    if (IsSubnetOverlap(subnet, subnetList))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }

            return false;
        }

        public static bool IsSubnetOverlap(string newSubnet, List<string> existingSubnets)
        {
            var (newStart, newEnd) = GetSubnetRange(newSubnet);

            foreach (var subnet in existingSubnets)
            {
                var (start, end) = GetSubnetRange(subnet);

                if (newStart <= end && newEnd >= start)
                {
                    return true;
                }
            }

            return false;
        }

        public static (long, long) GetSubnetRange(string subnet)
        {
            var parts = subnet.Split('/');
            var ip = IPAddress.Parse(parts[0]);
            var prefixLength = int.Parse(parts[1]);

            var ipBytes = ip.GetAddressBytes();
            Array.Reverse(ipBytes);
            var ipLong = BitConverter.ToInt32(ipBytes, 0);

            var mask = ~((1 << (32 - prefixLength)) - 1);
            var startIpLong = ipLong & mask;
            var endIpLong = ipLong | ~mask;

            return (startIpLong, endIpLong);
        }


    }

}
