using Calculing_Compare_Hash.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Calculing_Compare_Hash.Services
{
    public class EncryptService : IEncrypt
    {
        public string Encrypt(string text, string secret)
        {
            secret = secret ?? "";
            var enconding = new ASCIIEncoding();
            byte[] keyByte = enconding.GetBytes(secret);
            byte[] messageBytes = enconding.GetBytes(text);

            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hash = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
