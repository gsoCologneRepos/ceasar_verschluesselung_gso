using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CeasarVerschlusselung
{
    public class Decrypt
    {
        
        
        public static string Start(int key, string eingabe)
        {

            StringBuilder neuerSatz = new StringBuilder();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(eingabe);

            key = CheckLower(key);

            for (int i = 0; i <= asciiBytes.Length-1; i++)
            {
                    int pivot = asciiBytes[i];
                    key = CheckLower(pivot - key);
                    char zeichen = (char) (pivot - key);
                    neuerSatz.Append(zeichen);                 
            }

            return neuerSatz.ToString();
        }

        public static int CheckLower(int asciiChar)
        {
            if (asciiChar > 127)
            {
                asciiChar -= 127;
                return CheckLower(asciiChar);
            }
            else
            {
                return asciiChar;
            }
                
        }
    }
}