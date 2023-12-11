using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;


namespace DockerDesk.Helpers
{
    public static class FileHelpers
    {

        public static async Task CreateZipFileAsync(string sourceDirectory, string zipFilePath)
        {
            if (File.Exists(zipFilePath))
            {
                File.Delete(zipFilePath);
            }

            await Task.Run(() => ZipFile.CreateFromDirectory(sourceDirectory, zipFilePath));
        }

    }
}
