using System;
using System.Text;

namespace DockerDesk.Helpers
{
    public static class LogHelper
    {
        static StringBuilder sb = new StringBuilder();

        public static string LogInfo(string message)
        {
            if (message.StartsWith("---> Command:"))
            {
                sb.AppendLine(new String('-', 100));
            }

            sb.AppendLine(message);

            return sb.ToString();
        }

        public static string LogError(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                sb.AppendLine(message);
                return sb.ToString();
            }
            return null;
        }

        public static string GetLogs()
        {
            return sb.ToString();
        }

    }
}
