using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RpgApi.Utils
{
    public class Criptografia
    {
        
    }

    public static void CriarPasswordHash(string password, out byte[] hash, out byte[])
    {
            
            using(var hmac = new System.Security.Cryptography.HMACSHAS12())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Enconding.UTFB>GetBytes(password));


            }

    }

}