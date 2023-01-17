using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LoadJsonFile_WpfApp.Services
{
    public class FileService
    {
        public string FilePath { get; set; } = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json";

        public string ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(FilePath);
                return sr.ReadToEnd();
            }
            catch { return string.Empty; }
        }

        public void WriteToFile(string content)
        {
            try
            {
                using var sw = new StreamWriter(FilePath);
                sw.WriteLine(content);
            }
            catch {  }
        }
    }
}
