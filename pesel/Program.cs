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
           
            int[] cyfry = new int[11];
            for (int k = 0; k < litery.Length; k++)
            {
                cyfry[k]=Convert.ToInt16(litery[k])-48;
                Console.WriteLine(cyfry[k]);
            }
            int intMTH=cyfry[2]*10+cyfry[3];
            if (intMTH>12)
	{
                Console.WriteLine("za dużo miesięcy. XXI wiek?");
	}
            Console.WriteLine(paraDZIEN);   //pokazuje się pozostałość po wycięciu
            Console.ReadKey();

        }
    }
}
