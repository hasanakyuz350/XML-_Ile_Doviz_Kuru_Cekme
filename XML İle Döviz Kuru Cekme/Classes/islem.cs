using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XML_İle_Döviz_Kuru_Cekme.Model;

namespace XML_İle_Döviz_Kuru_Cekme.Classes
{
    public class islem : orTakbaglanTi
    {
        public void islemyapbuy()
        {
            Console.Write("\n" + "Müşteri adı: ");
            string mustriisim = Console.ReadLine();
            Console.Write("Müsşteri soyadı: ");
            string mustrisoyisim = Console.ReadLine();
            Console.Write("Döviz kodu: ");
            int kurkodu = int.Parse(Console.ReadLine());
            Console.Write("Yapılacak işlem: ");
            string islemturu = Console.ReadLine();

            var context = new ConsoledbProjeEntities();

            var guncelDeger = context.Tablocurrencyvalues
                        .Where(k => k.ID == kurkodu)
                        .Select(k => k.kuralisfiyat)
                        .FirstOrDefault();
            decimal gunceldeger = Convert.ToDecimal(guncelDeger);

            Console.Write("Miktar: ");
            decimal miktar = decimal.Parse(Console.ReadLine());

            decimal toplamucret = gunceldeger * miktar;
            Console.Write("Toplam ücret: " + toplamucret);

            islem i = new islem();

            i.islemyap(mustriisim, mustrisoyisim, kurkodu, islemturu, gunceldeger, miktar, toplamucret);
        }
        public void islemyapsell()
        {
            Console.Write("\n" + "Müşteri adı: ");
            string mustriisim = Console.ReadLine();
            Console.Write("Müsşteri soyadı: ");
            string mustrisoyisim = Console.ReadLine();
            Console.Write("Döviz kodu: ");
            int kurkodu = int.Parse(Console.ReadLine());
            Console.Write("Yapılacak işlem: ");
            string islemturu = Console.ReadLine();

            var context = new ConsoledbProjeEntities();

            var guncelDeger = context.Tablocurrencyvalues
                        .Where(k => k.ID == kurkodu)
                        .Select(k => k.kursatisfiyat)
                        .FirstOrDefault();
            decimal gunceldeger = Convert.ToDecimal(guncelDeger);

            Console.Write("Miktar: ");
            decimal miktar = decimal.Parse(Console.ReadLine());

            decimal toplamucret = gunceldeger * miktar;
            Console.Write("Toplam ücret: " + toplamucret);

            islem i = new islem();

            i.islemyap(mustriisim, mustrisoyisim, kurkodu, islemturu, gunceldeger, miktar, toplamucret);
        }
        public void islemyap(string musteriisim, string musterisoyisim, int kurkodu, string islemturu, decimal gunceldeger, decimal miktar, decimal toplamucret)
        {
            Tabloislem islem = new Tabloislem();
            islem.musteriisim = musteriisim;
            islem.musterisoyisim = musterisoyisim;
            islem.kurID = kurkodu;
            islem.islemturu = islemturu;
            islem.gunceldegeri = gunceldeger;
            islem.miktar = miktar;
            islem.toplamucret = toplamucret;
            islem.tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tabloislem.Add(islem);
            db.SaveChanges();
        }
    }
}