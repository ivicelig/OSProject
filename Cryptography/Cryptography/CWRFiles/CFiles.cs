using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cryptography.CWRFiles
{
    public static class CFiles
    {
        public static void CreateFile(string fileName)
        {
            string path = @"..\..\..\Files\" + fileName + ".txt";

            if (File.Exists(path))
            {
               
                File.Delete(path);
            }

            using (File.Create(path)) ;
            
        }

    }
}
