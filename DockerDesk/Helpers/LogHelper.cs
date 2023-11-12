using System;
using System.Text;

namespace DockerDesk.Helpers
{
    public static class LogHelper
    {
        static StringBuilder sb = new StringBuilder();

        public static void LogInfo(string message)
        {
            if (message.StartsWith("Command:"))
            {
                sb.AppendLine(new String('-', 100));
            }

            sb.AppendLine(message);
        }

        public static void LogError(string message)
        {
            sb.AppendLine(message);
        }

        public static string GetLogs()
        {
            return sb.ToString();
        }

    }
}
