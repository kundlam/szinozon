using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 40);
            Console.OutputEncoding = Encoding.UTF8;
            bool helyes = false;
            int tipSZ = 0;
            Random rnd = new Random();
            int szam = rnd.Next(1110, 6667);
           // Console.WriteLine(szam);

            for (int i = 0; i < 79; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");
            for (int i = 0; i < 40; i++)
            {
                Console.SetCursorPosition(79, 40 - i);
                Console.WriteLine("║");
            }
            Console.SetCursorPosition(79, 40);
            Console.Write("╝");
            
            for (int i = 0; i < 79; i++)
            {
                Console.SetCursorPosition(78-i, 40);
                Console.Write("═");
            }
            Console.Write("╚");
            for (int i = 0; i < 40; i++)
            {
                
            }
/*  
            do
            {
                Console.WriteLine("Válassz mennyi tipped legyen? [4-12]");
                tipSZ = Convert.ToInt32(Console.ReadLine());
                if (tipSZ >= 4 && tipSZ<=12)
                {
                    helyes = true;
                }
            } while (helyes == false);
            helyes = false;
            int[] tip = new int[tipSZ];
            for (int i = 0; i < tipSZ; i++)
            {
                do
                {
                    Console.WriteLine(i+1+". tipped: ");
                    tip[i] = Convert.ToInt32(Console.ReadLine());
                    if (tip[i] >= 1111 && tip[i] <= 6666)
                    {
                        helyes = true;
                    } else
                    {
                        Console.WriteLine("Nem helyes tipp [1111-6666]");
                    }
                } while (helyes==false);
                
            }
            for (int i = 0; i < tip.Length; i++)
            {
                Console.WriteLine(tip[i]);
            }
            */

            Console.ReadKey();
        }
    }
}