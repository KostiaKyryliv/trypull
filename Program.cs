using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trypull
{
    internal class Program
    {
        static void obrobka(string vvedenny, string keyword)
        {
            bool f = false;
            for (int i=0; i<3;i++)
            {
                if(vvedenny == keyword)
                {
                    System.Console.WriteLine("You win!");
                    f = false;
                }
                else
                {
                    System.Console.Write("Enter line again: ");
                    vvedenny = Console.ReadLine();
                }
                if (vvedenny != keyword && i==2)
                {
                    System.Console.WriteLine("you loose");
                }

            }
        }
        static void Main(string[] args)
        {
            string ryd = "yes";
            Console.Write("Enter your chois(you have 3 trys): ");
            string chois = Console.ReadLine();
            obrobka(chois, ryd);
        }
    }
}