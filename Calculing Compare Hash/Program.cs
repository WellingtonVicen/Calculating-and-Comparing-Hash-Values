using Calculing_Compare_Hash.Services;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Calculing_Compare_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Maquina de Encrypt e Decrypt  de Textos\n");

            Console.Write("Digite uma opcão  1 para Encrypt ou 2 para Decrypt: ");
            string opcao = Console.ReadLine();

            switch (opcao.ToLower())
            {
                case "1":
                    Console.WriteLine("MODO ------ ENCRYPT");
                    Console.Write("\nDigite o seu texto: ");
                    string text = Console.ReadLine();

                    Console.Write("Digite a Secret: ");
                    string secret = Console.ReadLine();

                    var encrypt = new EncryptService();
                    Console.WriteLine("\n Esse é seu texto criptografado: " + encrypt.Encrypt(text, secret));
                    break;
                case "2":

                    Console.WriteLine("MODO ------ DECRYPT");
                    Console.Write("Digite o seu texto: ");
                    string textD = Console.ReadLine();

             
                    var decrypt= new DecryptService();
                    Console.WriteLine("\n Esse é seu texto descriptografado: " + decrypt.Decrypt(textD));
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

       
    }
    
}
