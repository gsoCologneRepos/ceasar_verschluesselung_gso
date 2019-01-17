using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class TextDecrypt
    {
        public static void Start(int key,string path)
        {
            StringBuilder sb = new StringBuilder();
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path+"_decryped"); 
            String line = "";
            String decrypted ="";
            
            
            for(int i = 0; line != null; i++){
                line = file.ReadLine();
                decrypted = Decrypt.Start(key,line);
                sb.Append(decrypted);
                writer.WriteLine(decrypted);
            }
                
        }
    }
}