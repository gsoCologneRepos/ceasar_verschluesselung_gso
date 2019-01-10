using System;

namespace CeasarVerschlusselung
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Wähle eine Funktion:"); 
            Console.WriteLine("(1) Verschlüsseln");
            Console.WriteLine("(2) Entschlüsseln");
            Console.WriteLine("(3) Versuchen einen Satz zu entschluesseln");
            int mode = int.Parse(Console.ReadLine());

            //IO Beginnt
            Console.WriteLine("Geb deinen Satz ein: ");
            string eingabe = Console.ReadLine();
            

            //IO Beendet

            if(mode == 1)
            {
                Console.WriteLine("Gib um wie viele stellen soll verschoben werden?");
                int key = int.Parse(Console.ReadLine());
                Console.WriteLine(Encrypt.Start(key, eingabe));
            }
            if (mode == 2)
            {
                Console.WriteLine("Gib um wie viele stellen soll verschoben werden?");
                int key = int.Parse(Console.ReadLine());
                Console.WriteLine(Decrypt.Start(key, eingabe));
            }

            if (mode == 3) {
                BruteForce.Start(eingabe);
            }

            Console.ReadKey();
        }
    }
}