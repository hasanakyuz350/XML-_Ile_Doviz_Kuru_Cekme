using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_İle_Döviz_Kuru_Cekme.Classes
{
    public class kurlisTele_guncelkurlisTele_kurkaydeT : orTakbaglanTi
    {
        public void kurlistele()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\n" + "Döviz Listesi");
            var values = db.Tablocurrency.ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.kursembol + " " + value.kurisim);
            }
        }
        public void guncelkurlistele()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;-->C# programlarında konsola yazılan metnin UTF-8 karakter kodlamasıyla çıkmasını sağlar.

            Console.WriteLine("\n" + "Güncel Kur Listesi");
            var values = db.Tablocurrencyvalues.ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.Tablocurrency.kursembol + " " + value.Tablocurrency.kurisim + " Alış: " + value.kuralisfiyat + " Satış: " + value.kuralisfiyat);
            }
        }
        public void kurkaydet()
        {
            kuru_al al = new kuru_al();
            al.kurkaydetdolar();
            al.kurkaydeteuro();
            al.kurkaydetsterlin();
            al.kurkaydetyen();

            Console.WriteLine("Güncel kurlar kaydedildi!");
        }
    }
}