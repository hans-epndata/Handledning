using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_LoadJsonFile_ConsoleApp.Services
{
    internal class FileService
    {
        public string FilePath { get; set; } = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contacts.json";

        public string ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(FilePath);
                return sr.ReadToEnd();
            }
            catch { return string.Empty; }
        }

        public void SaveToFile(string content) 
        { 
            try
            {
                using var sw = new StreamWriter(FilePath);
                sw.WriteLine(content);
            }
            catch { }
        }
    }
}
