using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography.Signature
{
    public class Signature
    {
        public RSAPKCS1SignatureFormatter signatureFormatter;
        public RSAPKCS1SignatureDeformatter signatureDeformatter;
        public RSACryptoServiceProvider rsa;
        

        public Signature(RSACryptoServiceProvider RSA)
        {
            rsa = RSA;
            signatureFormatter = new RSAPKCS1SignatureFormatter(rsa);
            signatureDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
        }

        public byte[] CreateSignature(byte[] hash)
        {
            signatureFormatter.SetHashAlgorithm("SHA256");
            return signatureFormatter.CreateSignature(hash);   
        }


        public bool veritifySignature(byte[] hash, byte[] signedHash)
        {
            signatureDeformatter.SetHashAlgorithm("SHA256");
            if (signatureDeformatter.VerifySignature(hash,signedHash)==true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


    }
}
