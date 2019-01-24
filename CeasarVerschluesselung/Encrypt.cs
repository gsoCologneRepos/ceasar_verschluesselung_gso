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
            
            if (key > asciiBytes.Length - 1)
                key = key % asciiBytes.Length - 1;
            
            
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

