 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int sayinintersi=0;
            Console.WriteLine("sayı giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
            int orjisayi = sayi;
            do
            {
                sayinintersi = sayinintersi * 10;
                sayinintersi = sayinintersi + sayi % 10;
                sayi = sayi / 10;

            } while (sayi != 0);
            Console.WriteLine(orjisayi+"sayısının tersi =" + sayinintersi);
            Console.ReadLine(); 
        }
    }
}
