using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi;
            int b = 0;
            
         
            Console.Write("\tSayinizi girin: ");
            sayi = Convert.ToString(Console.ReadLine());
            int sayinin_basamakdegeri = sayi.Length;// eger girdigimiz sayi uzunlugu 2 ise 
            Console.WriteLine("Girdiginiz sayi {0} basamakli sayi ",sayi.Length);
            // bunu int olarak tanimlamamiz gerekiyor
            //ondan dolayi tanimlamayi boyle yaptik 


            for (int i = 0; i < sayi.Length; i++) 
            {
                sayinin_basamakdegeri  = sayinin_basamakdegeri  - 1;
                b = (int)Math.Pow(10, sayinin_basamakdegeri);
                Console.WriteLine("Sayinin rakami {0} -" +
                    "sayinin basamak degeri {1} dir", sayi[i], b);
                
                
            }
            Console.ReadLine();
        }
    } 
    
}
