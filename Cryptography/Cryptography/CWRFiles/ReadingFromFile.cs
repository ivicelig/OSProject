using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.ReadingWriteingInFile
{
    static class ReadingFromFile
    {
        public static string readFromFile(string name)
        {
            string path = @"..\..\..\Keys\"+name+".txt";
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string text = reader.ReadToEnd();
                    return text;
                }
            }
            catch (Exception e)
            {

                throw new Exception("Generic error occured!");
            }

        }


    }
}
