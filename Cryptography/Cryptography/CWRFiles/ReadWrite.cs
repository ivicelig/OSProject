using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Cryptography.CWRFiles
{
    public static class ReadWrite
    {
        public static bool DoesFileExist(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            return true;
        }

        public static void WriteToFile(string text, string filename)
        {
            string path = @"..\..\..\Files\"+filename+".txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }

        }

        public static string ReadFromFile(string fileName)
        {
            string path = @"..\..\..\Files\" + fileName + ".txt";
            if (DoesFileExist(path))
            {
                StreamReader reader = new StreamReader(path);
                string text = reader.ReadToEnd();
                reader.Close();
                return text;
            }
            return null;
        }
        

    }
}
