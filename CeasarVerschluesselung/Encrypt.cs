using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class Encrypt
    {
        public static String Start(int key, String eingabe)
        {

            StringBuilder neuerSatz = new StringBuilder();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(eingabe);
            for (int i = 0; i <= asciiBytes.Length - 1; i++)
            {
                int pivot = asciiBytes[i];
                char zeichen = (char) (pivot + key);
                neuerSatz.Append(zeichen);
            }
            return neuerSatz.ToString();
        }
        
    }
}

