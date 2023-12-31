﻿using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DockerDesk.Helpers
{
    public class DockerNetWorkChecker
    {
        public static async Task<(string Subnet, string Gateway)> IsNetworkRangeInUseAsync(string subnet, SshClientManager sshClientManager)
        {
            try
            {
                var client = sshClientManager.GetClient();

                if (client == null)
                {
                    MessageBox.Show("Please connect ssh client first.");
                    return (string.Empty, string.Empty);
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
                        var (suggestedSubnet, suggestedGateway) = SuggestAvailableSubnet(subnet, subnetList, 24);
                        return (suggestedSubnet, suggestedGateway);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Si è verificato un errore: {ex.Message}");
            }
            return (string.Empty, string.Empty);
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


        public static (string Subnet, string Gateway) SuggestAvailableSubnet(string desiredSubnet, List<string> existingSubnets, int subnetSize = 24)
        {
            var baseIp = desiredSubnet.Split('/')[0];
            var baseIpParts = baseIp.Split('.');

            if (baseIpParts.Length != 4) return (null, null);

            int thirdOctetStart = int.Parse(baseIpParts[2]);
            int thirdOctetEnd = 255;

            for (int i = thirdOctetStart; i <= thirdOctetEnd; i++)
            {
                string newSubnet = $"{baseIpParts[0]}.{baseIpParts[1]}.{i}.0/{subnetSize}";
                if (!IsSubnetOverlap(newSubnet, existingSubnets))
                {
                    string gateway = $"{baseIpParts[0]}.{baseIpParts[1]}.{i}.1";
                    return (newSubnet, gateway);
                }
            }

            return (null, null);
        }


        public static bool IsValidIPAddress(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var parts = input.Split('@');
            if (parts.Length != 2)
            {
                return false;
            }

            string ipAddress = parts[1];
            return IPAddress.TryParse(ipAddress, out _);
        }

        public static bool IsValidPort(string portString)
        {
            if (string.IsNullOrWhiteSpace(portString))
            {
                return false;
            }

            if (!int.TryParse(portString, out int port))
            {
                return false;
            }

            return port >= 0 && port <= 65535;
        }

        public static List<string> GetAllLocalIPv4Addresses()
        {
            List<string> ipAddresses = new List<string>();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddresses.Add(ip.ToString());
                }
            }
            return ipAddresses;
        }
    }

}
