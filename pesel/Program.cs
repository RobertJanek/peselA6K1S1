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

            //int[] litert=Convert.ToString(strPesel.ToCharArray());

            int[] cyfry = new int[11];
            for (int k = 0; k < litery.Length; k++)
            {
                cyfry[k]=Convert.ToInt16(litery[k])-48;
                Console.WriteLine(cyfry[k]);
            }
            int intROK=cyfry[0]*10+cyfry[1];//rok dwucyfrowo
            int intMTH=cyfry[2]*10+cyfry[3];//miesiąc dwucyfrowo
            int intDAY=cyfry[4]*10+cyfry[5];//dzień dwucyfrowo
            
            if (intDAY>31)
	        {
                Console.WriteLine("oszukałeś z datą dzienną.");
	        }
            
            if (intMTH>12)
	        {Console.WriteLine("za dużo miesięcy. XXI wiek?");
                do {intMTH-=20;} 
                while(intMTH>12);
                Console.WriteLine("Zmniejszyłem numer miesiąca do "+intMTH);
	        }
            
            Console.ReadKey();

        }
    }
}
