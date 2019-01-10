using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class BruteForce
    {
        public static void bruteForce(String text)
        {
            char[] alphabet = Alphabet.alphabet;
            int length = alphabet.Length - 1;
            for (int key = 0; key <= length; key++)
            {
                Console.WriteLine(Encrypt.encrypt(key,text));
            }
        }
    }
}