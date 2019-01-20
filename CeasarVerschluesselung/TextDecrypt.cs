using System;
using System.Text;

namespace CeasarVerschlusselung
{
    public class TextDecrypt
    {
        public static void Start(int key,string path)
        {
            try
            {              
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                String text = file.ReadToEnd();
                System.IO.File.WriteAllText(path+"_decryped.txt",Decrypt.Start(key,text));
                Console.WriteLine("Fertig!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("ERROR!");
            }
        }
    }
}