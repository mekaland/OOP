using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Musteri musteri = new Musteri("Opel", "Corsa",2010,56000);
            musteri.AlisFiyat = 28000;
            musteri.SatisFiyat = 32000;
            musteri.MaxIndirimTutar = 1500;
            musteri.FiyatAta(40000);
            musteri.BilgileriGoruntule();
            
        
            

            Console.ReadKey();

        }
    }

    
}
