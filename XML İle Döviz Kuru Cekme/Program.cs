using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XML_İle_Döviz_Kuru_Cekme.Classes;
using XML_İle_Döviz_Kuru_Cekme.Model;
using System.Windows.Forms;

namespace XML_İle_Döviz_Kuru_Cekme
{
    public class Program : orTakbaglanTi
    {
        static void Main(string[] args)
        {
            showinfo showinfo = new showinfo();

            Console.Write("\n"+"İşlem numarası: ");
            string secim = Console.ReadLine();

            while (secim != "8")
            {
                switch (secim)
                {
                    case "1":
                    case "01":
                        kurlisTele_guncelkurlisTele_kurkaydeT kurlis = new kurlisTele_guncelkurlisTele_kurkaydeT();
                        kurlis.kurlistele();
                        break;
                    case "2":
                    case "02":
                        kurlisTele_guncelkurlisTele_kurkaydeT kurlis1 = new kurlisTele_guncelkurlisTele_kurkaydeT();
                        kurlis1.guncelkurlistele();
                        break;
                    case "3":
                    case "03":
                        string[] islem_buy = { "alis", "alıs", "alış", "aliş" };
                        string[] islem_sell = { "satıs", "satış", "satiş", "satis" };
                        islem yap = new islem();
                        if (db.Tabloislem.Any(x => islem_buy.Contains(x.islemturu.ToLower())))
                        {
                            yap.islemyapbuy();
                        }
                        else if (db.Tabloislem.Any(x => islem_sell.Contains(x.islemturu.ToLower())))
                        {
                            yap.islemyapsell();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen yapılacak işlemi belirtiniz!");
                        }
                        break;
                    case "4":
                    case "04":
                        islemlisTele islemlis = new islemlisTele();
                        islemlis.islemlisTelebuy();
                        break;
                    case "5":
                    case "05":
                        islemlisTele islemlis1 = new islemlisTele();
                        islemlis1.islemlisTelesell();
                        break;
                    case "6":
                    case "06":
                        kurlisTele_guncelkurlisTele_kurkaydeT kurkaydeT = new kurlisTele_guncelkurlisTele_kurkaydeT();
                        kurkaydeT.kurkaydet();
                        break;
                    case "7":
                    case "07":
                        MessageBox.Show("hasannn2003@gmail.com" + "\n" + "adresine mail yollayabilirsiniz.", "Sorun Mu Var?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                Console.Write("\n"+"İşlem numarası: ");
                secim = Console.ReadLine();
            }

            if (secim == "8")
            {
                //Exit()-->Bu metot, Environment sınıfının bir static methodudur.
                Environment.Exit(0);
                //Environment-->C#’da System isim alanı (namespace) içinde bulunan hazır bir sınıftır.
                //           -->Programın çalıştığı sistem hakkında bilgi almanı sağlar. Ayrıca bazı yardımcı sistem komutları sağlar (örneğin: programı kapatmak) .
            }

            Console.ReadLine();
        }
    }
}