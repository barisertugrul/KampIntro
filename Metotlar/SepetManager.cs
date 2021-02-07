using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention _ Metotların ilk harfi büyük
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler! {0} sepete eklendi.",urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. {0} sepete eklendi",urunAdi);
        }
    }
}
