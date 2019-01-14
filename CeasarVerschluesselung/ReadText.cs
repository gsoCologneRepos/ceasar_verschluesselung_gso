using System;

namespace CeasarVerschlusselung
{
    public class TextDateiEncrypt
    {
        public static void Read(string path)
        {
            StringBuilder sb = new StringBuilder();
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path+_encryped); 
            thisLine = file.ReadLine();
            String line = "";
            String crypted ="";
            
            
            for(int i = 0; thisLine != null; i++){
                line = ReadLine();
                crypted = Encryp(line);
                sb.Append(crypted);
                writer.WriteLine(crypted);
            }
                
        }
    }
}