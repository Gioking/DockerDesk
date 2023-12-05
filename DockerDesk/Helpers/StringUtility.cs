namespace DockerDesk.Helpers
{
    using System;
    using System.Linq;

    public class StringUtility
    {
        public static string NormalizeDockerOutput(string dockerOutput)
        {
            return string.Join("\n", dockerOutput
                .Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => string.Join(" ", line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries))));
        }
    }

}
