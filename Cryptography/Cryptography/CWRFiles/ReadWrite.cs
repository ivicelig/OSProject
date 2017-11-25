using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Cryptography.CWRFiles
{
    static class ReadWrite
    {
        static public bool DoesFileExist(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            return true;
        }


    }
}
