using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     internal class Musteri
    {
        public string arac;
        public string model;
        public string YakıtTuru;
        public int modelYıl;
        public int km;
        public int vitesTip;
        public decimal AlisFiyat;
        public decimal SatisFiyat;
        public decimal MaxIndirimTutar;
        public decimal Fiyat;


        public Musteri()
        {

        }

        public Musteri(string _arac,string _model)
        {
            arac = _arac;
            model = _model;
        }

        public Musteri(string _arac, string _model, int _modelyil)
        { 
            arac = _arac;
            model = _model;
            modelYıl = _modelyil;
        }

        public Musteri(string _arac, string _model, int _modelyil, int _km)
        {
            arac = _arac;
            model = _model;
            modelYıl = _modelyil;
            km = _km;
        }

        public void BilgileriGoruntule()
        {
        Console.WriteLine("Araç bilgileriniz Aşağıdadır");
        Console.WriteLine("Araç adı: {0}, Araç modeli: {1}, model yılı: {2}, km: {3}", arac, model, modelYıl,km);

        }
        public void FiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyat - MaxIndirimTutar;
            if(_fiyat < fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi yaptınız");

            }else
            {
                 this.Fiyat =  _fiyat;
                Console.WriteLine("Fiyat Güncellendi");
            }
        }

    }
    
}
