using System.Text;

namespace DockerDesk.Helpers
{
    public static class LogHelper
    {
        static StringBuilder sb = new StringBuilder();

        public static void LogInfo(string message)
        {
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
