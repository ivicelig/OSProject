using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Cryptography.Signature
{
    public static class Hash
    {
        public static byte[] ComputeHashForMessage(byte[] cipherBytes)
        {

            SHA256Managed alg = new SHA256Managed();
            byte[] hash = alg.ComputeHash(cipherBytes);
            return hash;
        }

    }
}
