using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_İle_Döviz_Kuru_Cekme.Classes
{
    public class islemlisTele : orTakbaglanTi
    {
        string[] islem_buy = { "alis", "alıs", "alış", "aliş" };
        string[] islem_sell = { "satıs", "satış", "satiş", "satis" };
        public void islemlisTelebuy()
        {
            var values = db.Tabloislem.Where(x => islem_buy.Contains(x.islemturu.ToLower())).ToList();
            foreach (var value in values)
            {
                Console.WriteLine("ID: " + value.ID + "\n" + "İsim ve soyisim: " + value.musteriisim + " " + value.musterisoyisim + "\n" + "Döviz: " + value.Tablocurrency.kurisim + "\n" + "Yapılacak işlem: " + value.islemturu + "\n" + "Güncel kur değeri: " + value.gunceldegeri + "\n" + "Birim miktarı: " + value.miktar + "\n" + "Toplam ücret: " + value.toplamucret + "\n" + "Tarih: " + value.tarih + "\n");
            }
        }
        public void islemlisTelesell()
        {
            var values = db.Tabloislem.Where(x => islem_sell.Contains(x.islemturu.ToLower())).ToList();
            foreach (var value in values)
            {
                Console.WriteLine("ID: " + value.ID + "\n" + "İsim ve soyisim: " + value.musteriisim + " " + value.musterisoyisim + "\n" + "Döviz: " + value.Tablocurrency.kurisim + "\n" + "Yapılacak işlem: " + value.islemturu + "\n" + "Güncel kur değeri: " + value.gunceldegeri + "\n" + "Birim miktarı: " + value.miktar + "\n" + "Toplam ücret: " + value.toplamucret + "\n" + "Tarih: " + value.tarih + "\n");
            }
        }
    }
}