# Randevu_Sistem

## Bir klinik için web sayfası

<hr>

#### Projenin backend için C# dili ile yazdım ve ağırlıklı olarak .net Framework kullandım.

<br>

#### Arayüz için, Default sayfası ve Login, Signup ve Forgot password sayfaları için 2 hazır şablon kullandım.ve kullanıcının sayfasını oluşturmak için HTML, CSS ve javascript kullandım.

<hr>

### Bu web sitesinde 3 çeşit kullanıcı vardır:

1.Hasta randevu alabilir ve mevcut randevularını görebilir. Ayrıca gittiği doktorun teşhisi ve reçetesi ile kliniğe son ziyaretlerini görebilir. sonunda kendi kişisel bilgilerini görebilir.(Kendisi için bir hesap oluşturabilir).
<br>
2.Doktor, hastasının o günkü randevusunu görebilir ve hastası için teşhis ve reçete yazabilir. Ayrıca, kişisel bilgilerini görebilir.(Yalnızca yönetici onun için bir hesap oluşturabilir)
<br>
3.3. Kliniğin resepsiyon görevlisi veya sekreter o gün tüm hastaların randevularını görebilir.(Yalnızca yönetici onun için bir hesap oluşturabilir)
<hr>

### Kullandığım Asp.net Teknolojileri:

-Projede 4 katman bulunmaktadır. Web sayfası(aspx sayfaları, mastepage, kullanıcı kontrolleri ve Tasarım klasörü vardır), Siniflarim (ihtiyacım olan tüm sınıflara sahiptir), Veritabani (bu katmanda projeyi veritabanıma bağladım) ve son olarak WebApi (vardı) yazdığım API'lerin Controllers ve Models).<br>
- Veritabanımı MS SQL'de oluşturdum ve veritabanındaki verilere ulaşmak için Entity Framework kullandım.<br>
- Her sayfa ve kullanıcı için farklı olan Container dışında aynı düzene sahip kullanıcı sayfaları için **Master Page** kullandım.<br>
- 2 kullanıcı kontrolü oluşturdum. İlki, web sitesinin menü yapısıyla ilgilidir. ikincisi veritabanından kullanıcı adı ve bilgileri okur ve bunları Bilgilerim sayfasında gösterir.<br>
- Web siteme kullanılabilirlik ve profesyonellik katmak için Global.asax sayfasını kullanarak web sitesi URL'lerini yeniden yazdım.<br>
- Projeye 3 adet Web API ekledim fakat kullanmayı amaçlamadım sadece web Api hakkında daha fazla bilgi edinmek için ekledim.
