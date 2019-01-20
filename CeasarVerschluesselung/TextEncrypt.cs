using System;
using System.Text;

namespace CeasarVerschlusselung
{
    internal class TextEncrypt
    {
        public static void Start(int key,string path)
        {
            try
            {              
                System.IO.StreamReader file = new System.IO.StreamReader(path);
                String text = file.ReadToEnd();
                System.IO.File.WriteAllText(path+"_encryped.txt",Encrypt.Start(key,text));
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