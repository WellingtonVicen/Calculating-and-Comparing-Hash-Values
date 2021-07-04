using Calculing_Compare_Hash.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculing_Compare_Hash.Services
{
    public class DecryptService : IDecrypt
    {
        public string Decrypt(string base64Encrypt)
        {
            var decrpty = Convert.FromBase64String(base64Encrypt);
            var str = Encoding.UTF8.GetString(decrpty);

            return str;
        }
    }
}
