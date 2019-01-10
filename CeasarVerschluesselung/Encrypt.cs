using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class Encrypt
    {
        public static String encrypt(int key, String eingabe)
        {
            char[] alphabet = Alphabet.alphabet;

            StringBuilder neuerSatz = new StringBuilder();

            foreach (char c in eingabe )
            {
                for (int j = 0; j <= alphabet.Length - 1; j++)
                {
                    if (c.Equals(alphabet[j]))
                    {

                        if (j + key > alphabet.Length)
                        {
                            neuerSatz.Append(alphabet[j + key - alphabet.Length]);
                        }
                        else
                        {
                            neuerSatz.Append(alphabet[j + key]);
                        }


                        break;
                    }
                }
            }
            return neuerSatz.ToString();
        }
    }
}