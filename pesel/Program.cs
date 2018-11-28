using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj");
            String strPesel;
            strPesel=Console.ReadLine();
            //int intPesel = Convert.ToInt32(strPesel);
            char[] litery = strPesel.ToArray();

            for (int k = 0; k < litery.Length; k++)
            {
                Console.WriteLine(litery[k]);
            }
            String paraROK = strPesel.Remove(0, 2);
            String paraMIESIAC = strPesel.Remove(2, 2);
            String paraDZIEN = strPesel.Remove(4, 2);
            String czworkaROK = strPesel.Remove(6, 4);

            Console.WriteLine(paraDZIEN);   //pokazuje się pozostałość po wycięciu
            Console.ReadKey();

        }
    }
}
