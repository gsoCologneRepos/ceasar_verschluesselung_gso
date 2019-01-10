using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class BruteForce
    {
        public static void bruteForce(char[] satz)
        {
            char[] alphabet = Alphabet.alphabet;
            
            for (int zahl = 0; zahl <= alphabet.Length; zahl++)
            {
                StringBuilder neuerSatz = new StringBuilder();
                for (int i = 0; i <= satz.Length-1; i++)
                {
                    for (int j = 0; j <= alphabet.Length-1; j++)
                    {
                        if (satz[i].Equals(alphabet[j]))
                        {
                            neuerSatz.Append(alphabet[j + zahl]);

                        }
                    }
                    Console.WriteLine(zahl+"."+ " " +neuerSatz.ToString());
                }
            }
        }
    }
}