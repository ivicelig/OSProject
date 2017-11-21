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
        public static List<string> readFromFile(string name)
        {
            string path = @"..\..\..\Keys\"+name+".txt";
            string line = "";
            List<string> text = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        text.Add(line);
                    }
                    
                }
                return text;
            }
            catch (Exception e)
            {

                throw new Exception("Generic error occured!");
            }

        }


    }
}
