using System;

namespace CeasarVerschlusselung
{
    public class BruteForce
    {
        public static void Start(string text)
        {
            char[] alphabet = Alphabet.alphabet;
            int length = alphabet.Length - 1;

            for (int key = 0; key <= length; key++)
            {
                Console.WriteLine(Encrypt.Start(key,text));
            }
        }
    }
}