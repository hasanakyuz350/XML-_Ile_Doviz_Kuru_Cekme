💱 C# Konsol Döviz Uygulaması

Bu proje, C# konsol uygulaması olarak geliştirilmiş basit bir döviz yönetim sistemidir. TCMB (Türkiye Cumhuriyet Merkez Bankası) XML servisleri kullanılarak güncel döviz kurları çekilir. Kullanıcı, veri tabanına kayıtlı kurlar üzerinden alış ve satış işlemleri yapabilir, geçmiş işlemleri görüntüleyebilir.

🚀 Özellikler

- **XML ile TCMB'den döviz kurlarını çekme
- **
- **Kur ekleme / güncelleme
- **
- **Alış ve satış işlemleri gerçekleştirme
- **
- **Yapılan işlemleri listeleme
- **
- **Veri tabanı ile işlem ve kur saklama

🛠️ Kullanılan Teknolojiler

- **C# (.NET)
- **
- **XML veri çekme
- **
- **Entity Framework (veri tabanı işlemleri için)
- **
- **SQL (veri tabanı)


📂 Proje Yapısı

 Classes

- ** islem.cs                                
- ** islemlisTele.cs                         
- ** kurlisTele_guncelkurlisTele_kurkaydeT.cs
- ** kuru_al.cs                              
- ** orTakbaglanTi.cs                        
- ** showinfo.cs                             

 DaTabase

 - **script.sql

 Model

- **Model1.edmx 
- **Tablocurrency.cs
- **Tablocurrencyvalues.cs
- **Tabloislem.cs

Ana Program

 - **Program.cs
 - **App.config


📌 Notlar

- **TCMB XML servisi sadece mesai saatlerinde veri sağlar. Hafta sonu ve tatil günlerinde kur verisi bulunmayabilir.

- **Proje geliştirme amaçlıdır, ticari kullanım için optimize edilmemiştir.
