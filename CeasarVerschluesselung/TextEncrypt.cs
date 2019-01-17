using System;
using System.Text;

namespace CeasarVerschlusselung
{
    internal class TextEncrypt
    {
        public static void TextEncrypt(string path)
        {
            StringBuilder sb = new StringBuilder();
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path+"_encryped"); 
            String line = "";
            String crypted ="";
            
            
            for(int i = 0; line != null; i++){
                line = file.ReadLine();
                crypted = Encrypt.Start(line);
                sb.Append(crypted);
                writer.WriteLine(crypted);
            }
                
        }
    }
}