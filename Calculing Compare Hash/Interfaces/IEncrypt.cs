using System;
using System.Collections.Generic;
using System.Text;

namespace Calculing_Compare_Hash.Interfaces
{
   public interface IEncrypt
   {
        public string Encrypt(string text, string secret);
   }
}
