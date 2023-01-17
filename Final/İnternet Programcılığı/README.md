# Final
 Kullanılan teknolojiler:
Program entity framework core  Database first yaklaşımıyla mvc asp.net core kullanılarak yapıldı.
Visual Studio 2022
Sql Server 2019
Bootstrap 5

Projeye dahil edilenler:
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer

Database bağlamak için:
İlk kez:
Scaffold-DbContext "Server=.\SQLEXPRESS;Database=Employee;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir data
Güncellemek için:
Update:
Scaffold-DbContext "Server=.\SQLEXPRESS;Database=Employee;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir data -force


ASP.NET MVC projemizin ana dizinleri şu şekilde:
/Controllers ->URL isteklerini işleyen Denetleyici sınıflarını yerleştirdiğiniz yer
/Models	->Verileri temsil eden ve işleyen sınıfları yerleştirdiğiniz yer
/Views->Çıkışı işlemeden sorumlu kullanıcı arabirimi şablon dosyalarını yerleştirdiğiniz yer

/data ise database bilgilerinin projeye dahil edildiği bölüm.
DersTab.cs
OgrenciDersTab.cs
OgrenciTab.cs
OkulYonetimTab.cs
OkulDBContext.cs öğelerinden oluşur.

/Views dizininde 
Ders
Ogrenci
OgrenciDers
OkulYonetim
Home, dosyaları bulunur.
Her bir dosyanın alt dizininde ise
Guncelle.cshtml
Kaydet.cshtml
Index.cshtml, öğeleri bulunur.

/Views/Shared/_Layout.cshtml dizininde ise projenin bootstrap 5 kodları bulunmaktadır. Navbar dropdown menü şeklinde oluşturuldu. Bu kodların kullanımı için öncelikle 
/OkulProje/wwwroot/js dizininde aşağıdaki link içinde verilen bilgiler kopyalanıp yapıştırılır.
Link: https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js

