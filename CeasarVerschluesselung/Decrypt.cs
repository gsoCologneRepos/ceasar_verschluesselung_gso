using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class Decrypt
    {
        public static String decrypt(int key, char[] satz)
        {
            char[] alphabet = Alphabet.alphabet;
            StringBuilder neuerSatz = new StringBuilder();
            for (int i = 0; i <= satz.Length-1; i++)
            {
                for (int j = 0; j <= alphabet.Length-1; j++)
                {
                    if (satz[i].Equals(alphabet[j]))
                    {

                        if (j - key < 0)
                        {
                            neuerSatz.Append(alphabet[j - key + alphabet.Length]);
                        }
                        else
                        {
                            neuerSatz.Append(alphabet[j - key]);
                        }
                        break;
                    }
                }
            }

            return neuerSatz.ToString();
        }
    }
}