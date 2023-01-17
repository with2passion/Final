# Final
Projeye dahil edilenler:
EntityFramework.SqlServer

Database bağlantısı için:
Proje çözümü kısmına sağ tık yapılarak ekle başlığının üzerine gidilir oradan da yeni öğe (ctrl+shift+A) başlığına girilir. Açılan pencerenin sol kısmında veri(data) kısmına gerilerek ADO.NET Entity Data Model seçilir ve eklenir. Ardından seçilen sql veritabanı ilgili bilgiler girildikten sonra kaydedilir.

Main Formu Form1.cs ögesidir. main formuna tool box aracılığı ile menuStrip eklenir ardından Anasayfa, Ders, Personel, Öğrenci kısımları eklenir. başlıkların her birinin altında giriş ve listele kısımları bulunmaktadır. MenuStrip’in altına ise toolStrip eklenir. Anasayfanın en alt kısmına sayfa durumlarını belirtme amacı ile statusStrip eklenir.  
Giriş Formlarında ilgili menü başlığına uygun olarak database kayıt alanları oluşturuldu.
Liste formlarında, ilgili kayıtlar listelenir ve formun üstünde filtre seçenekleri oluşturuldu,
Listelenen datalarda renk datası içeren kayıtlar renklere göre data grid satırları renklenir,
Liste formlarında ilgili kayıtlar güncelleme, silme işlemleri ayrı formlar çağrılacak şekilde oluşturuldu.