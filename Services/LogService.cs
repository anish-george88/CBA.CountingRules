using CBA.Services.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace CBA.Services
{
    public class LogService : ILogger
    {
        private string FileName = string.Empty;
        public LogService(string fileName)
        {
            FileName = fileName;
        }

        public async Task Log(string message)
        {
            string filePath = Directory.GetCurrentDirectory();
            File.WriteAllText(filePath + @"\" + FileName, message);
        }
    }
}