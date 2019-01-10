using System.Text;

namespace CeasarVerschlusselung
{
    public class Decrypt
    {
        
        
        public static string Start(int key, string eingabe)
        {
            char[] alphabet = Alphabet.alphabet;

            StringBuilder neuerSatz = new StringBuilder();

            foreach (char c in eingabe )
            {
                for (int i = 0; i <= alphabet.Length - 1; i++)
                {
                    if (c.Equals(alphabet[i]))
                    {

                        if (i + key > alphabet.Length-1)
                        {
                            neuerSatz.Append(alphabet[i + key + alphabet.Length-1]);
                        }

                        else
                        {
                            neuerSatz.Append(alphabet[i - key]);
                        }
                    }
                }
            }

            return neuerSatz.ToString();
        }
    }
}