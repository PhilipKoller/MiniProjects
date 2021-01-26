using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value To Hash: ");
            string userInput = Console.ReadLine();

            byte[] hashValue = GetHash(userInput,"SHA-512");

            //Display Hash
            string hashedString = "";
            foreach (var item in hashValue)
            {
                hashedString += item;
            }
            Console.WriteLine(hashedString);
            Console.ReadKey();
        }
        static byte[] GetHash(string input, string algoType)
        {
            var hasher = HashAlgorithm.Create(algoType);
            var valueBytes = Encoding.ASCII.GetBytes(input);

            hasher.ComputeHash(valueBytes);
            return hasher.Hash;
        }
    }
}
