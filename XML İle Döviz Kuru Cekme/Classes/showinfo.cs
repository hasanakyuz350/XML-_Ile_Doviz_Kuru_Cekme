using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_İle_Döviz_Kuru_Cekme.Classes
{
    public class showinfo
    {
        public showinfo()
        {
            Console.WriteLine("Döviz İşlemlerine Hoşgeldiniz!                                                                      Tarih: " + DateTime.Now.ToShortDateString() + "\n");
            Console.WriteLine("Yapmak istediğiniz işlemi seçin: " + "\n");
            Console.WriteLine("1- Döviz işlemleri");
            Console.WriteLine("2- Güncel kur işlemleri");
            Console.WriteLine("3- Satış işlemleri");
            Console.WriteLine("4- Müşterilere yapılan alış hareketleri");
            Console.WriteLine("5- Müşterilerden alınan satış hareketleri");
            Console.WriteLine("6- Kurları veri tabanına kaydet");
            Console.WriteLine("7- Yardım");
            Console.WriteLine("8- Çıkış yap" + "\n");
        }
    }
}