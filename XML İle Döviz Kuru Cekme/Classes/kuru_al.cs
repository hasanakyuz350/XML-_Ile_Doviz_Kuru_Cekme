using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_İle_Döviz_Kuru_Cekme.Model;

namespace XML_İle_Döviz_Kuru_Cekme.Classes
{
    public class kuru_al : orTakbaglanTi
    {
        public void kurkaydetdolar()
        {
            var eskiDolarlar = db.Tablocurrencyvalues.Where(x => x.kurID == 2);
            db.Tablocurrencyvalues.RemoveRange(eskiDolarlar);
            db.SaveChanges();

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            //XmlDocument()-->XmlDocument sınıfından yeni bir nesne oluşturuluyor.

            xmlDoc.Load(today);
            //Load(Tanımlanan URL nesnesi) ile URL'den XML verisi çekiliyor ve belleğe yükleniyor.

            string dolaralis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexBuying").InnerXml;
            //.InnerXml-->Bir XML düğümünün (node) içindeki etiketler dahil tüm içeriği metin (string) olarak verir.
            dolaralis = dolaralis.Replace(".", ",");
            string dolarsatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
            //.SelectSingleNode(XML içinde bir düğümün yerini tarif eden adres (XPATH))-->Bu metot, XML içinde verilen XPath ifadesine uygun olan ilk düğümü (node) bulur ve getirir.
            dolarsatis = dolarsatis.Replace(".", ",");

            Tablocurrencyvalues c = new Tablocurrencyvalues();
            c.kurID = 2;
            c.kuralisfiyat = Convert.ToDecimal(dolaralis);
            c.kursatisfiyat = Convert.ToDecimal(dolarsatis);
            c.tarih = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            db.Tablocurrencyvalues.Add(c);
            db.SaveChanges();
        }
        public void kurkaydeteuro()
        {
            var eskiDolarlar = db.Tablocurrencyvalues.Where(x => x.kurID == 3);
            db.Tablocurrencyvalues.RemoveRange(eskiDolarlar);
            db.SaveChanges();

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string euroalis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexBuying").InnerXml;
            euroalis = euroalis.Replace(".", ",");
            string eurosatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerXml;
            eurosatis = eurosatis.Replace(".", ",");

            Tablocurrencyvalues c = new Tablocurrencyvalues();
            c.kurID = 3;
            c.kuralisfiyat = Convert.ToDecimal(euroalis);
            c.kursatisfiyat = Convert.ToDecimal(eurosatis);
            c.tarih = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            db.Tablocurrencyvalues.Add(c);
            db.SaveChanges();
        }
        public void kurkaydetsterlin()
        {
            var eskiDolarlar = db.Tablocurrencyvalues.Where(x => x.kurID == 4);
            db.Tablocurrencyvalues.RemoveRange(eskiDolarlar);
            db.SaveChanges();

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string sterlinalis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexBuying").InnerXml;
            sterlinalis = sterlinalis.Replace(".", ",");
            string sterlinsatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexSelling").InnerXml;
            sterlinsatis = sterlinsatis.Replace(".", ",");

            Tablocurrencyvalues c = new Tablocurrencyvalues();
            c.kurID = 4;
            c.kuralisfiyat = Convert.ToDecimal(sterlinalis);
            c.kursatisfiyat = Convert.ToDecimal(sterlinsatis);
            c.tarih = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            db.Tablocurrencyvalues.Add(c);
            db.SaveChanges();
        }
        public void kurkaydetyen()
        {
            var eskiDolarlar = db.Tablocurrencyvalues.Where(x => x.kurID == 5);
            db.Tablocurrencyvalues.RemoveRange(eskiDolarlar);
            db.SaveChanges();

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            string yenalis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/ForexBuying").InnerXml;
            yenalis = yenalis.Replace(".", ",");
            string yensatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='JPY']/ForexSelling").InnerXml;
            yensatis = yensatis.Replace(".", ",");

            Tablocurrencyvalues c = new Tablocurrencyvalues();
            c.kurID = 5;
            c.kuralisfiyat = Convert.ToDecimal(yenalis);
            c.kursatisfiyat = Convert.ToDecimal(yensatis);
            c.tarih = Convert.ToDateTime(DateTime.Now.ToShortTimeString());
            db.Tablocurrencyvalues.Add(c);
            db.SaveChanges();
        }
    }
}