using System;

namespace CeasarVerschlusselung
{
    public class BruteForce
    {
        public static void Start(string text)
        {
            int asciiLength = 127;
            for (int key = 0; key <= asciiLength; key++)
            {
                Console.WriteLine(key+": "+Decrypt.Start(key,text));
            }
        }
    }
}
