using System;

namespace CryptoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, World!";
            string password = "MYPASSWORD";

            string encrypted = PBEWithMD5AndDES.Encrypt(text, password);
            Console.WriteLine("encrypted: " + encrypted);

            string decrypted = PBEWithMD5AndDES.Decrypt(encrypted, password);
            Console.WriteLine("decrypted: " + decrypted);
        }
    }
}
