📚 StudyTalks – Ders Odaklı Paylaşım ve Etkileşim Platformu

StudyTalks
, kullanıcıların derslerle ilgili gönderiler (postlar) paylaşabildiği, bu gönderilere etiket (tag) ekleyebildiği,
diğer kullanıcılarla yorumlar üzerinden etkileşime girebildiği modern bir eğitim temalı blog uygulamasıdır.
ASP.NET Core MVC ve Entity Framework Core teknolojileriyle geliştirilmiştir.


📝 1. Gönderiler (Postlar)

Uygulamanın ana sayfasında kullanıcılar tarafından oluşturulmuş gönderiler listelenir. Bu gönderiler derslerle ilgili konular içerir.


<img width="1894" height="916" alt="image" src="https://github.com/user-attachments/assets/713b020d-2e38-4907-9b24-b0fc4d916c04" />

💬 2. Yorum Yapma ve Yorumları Görme

Her gönderinin altında, kullanıcılar yorum yapabilir. Ayrıca diğer kullanıcıların daha önce yaptığı yorumlar da listelenir. Bu şekilde fikir alışverişi desteklenir. Gönderiyi kimin paylaştığı da görünür


<img width="1887" height="912" alt="image" src="https://github.com/user-attachments/assets/72d49ea6-8e6a-4669-84e1-5e8e8d797090" />


🏷️ 3. Tag (Etiket) Sistemi

Her gönderiye, dersin konusuna uygun etiketler (örneğin: "PHP", "Veri Yapıları", "Web Programlama") eklenebilir. Gönderinin üst kısmında bu etiketler gösterilir.
Etiketlerden birine tıklayan kullanıcı, aynı etikete sahip diğer gönderileri görebilir.


<img width="1898" height="548" alt="image" src="https://github.com/user-attachments/assets/be417783-3cac-4ec5-988d-3f8adc4c5133" />


👤 4. Kullanıcı Kaydı ve Girişi

Ziyaretçiler uygulamaya kayıt olabilir ve giriş yaptıktan sonra yorum yapabilir, gönderi ekleyebilir, gönderilerini düzenleyebilir.


<img width="1917" height="933" alt="image" src="https://github.com/user-attachments/assets/7ebc0448-aec2-487c-a8dc-562c0f910540" />
<img width="1915" height="659" alt="image" src="https://github.com/user-attachments/assets/0438611f-33aa-4ac8-be0a-fd6fd5cb57d0" />
<img width="780" height="72" alt="image" src="https://github.com/user-attachments/assets/5e27f98b-0e34-4626-ab27-8ddabd54c237" />


✍️ 5. Gönderi Paylaşımı

Giriş yapmış bir kullanıcı:

Başlık, açıklama, içerik girerek,

İlgili dersi temsil eden tag(ler) seçerek,

İsteğe bağlı bir görsel seçerek
kendi gönderisini paylaşabilir.


<img width="1907" height="926" alt="image" src="https://github.com/user-attachments/assets/30203b60-a108-4638-a892-79c0e62a44fd" />
<img width="1914" height="925" alt="image" src="https://github.com/user-attachments/assets/5f607aa1-1d36-48b7-9595-62c152a600d3" />
<img width="1883" height="917" alt="image" src="https://github.com/user-attachments/assets/31d8770b-e160-469c-9f4d-070ee629dc46" />


🔍 6. Yorum Geçmişi İnceleme

Bir yorumun yazarının adına tıklayan kullanıcı, o kişinin daha önce yaptığı tüm yorumları görebilir.
Bu özellik, kullanıcılar arası etkileşimi güçlendirir

<img width="1915" height="925" alt="image" src="https://github.com/user-attachments/assets/32b28847-23dc-4e57-af8a-6b6d77bc0298" />




🛠️ Kullanılan Teknolojiler
ASP.NET Core MVC: Web uygulamasının temel çatısıdır. Model-View-Controller mimarisi ile kodun düzenli ve yönetilebilir olmasını sağlar.

Entity Framework Core: Veritabanı işlemlerini nesne tabanlı yapmayı kolaylaştıran ORM aracıdır.

SQLite: Hafif, dosya tabanlı veritabanı çözümüdür. Projede hızlı ve kolay kurulum için tercih edilmiştir.

Bootstrap: Responsive ve modern kullanıcı arayüzleri oluşturmak için kullanılan CSS framework’üdür.

TinyMCE: Kullanıcıların gönderi içeriğini zengin biçimde düzenleyebilmeleri için entegre edilen metin editörüdür.


🗄️ Veritabanı Yönetimi
Projede veritabanı işlemleri için Entity Framework Core kullanılmıştır. Veritabanı olarak SQLite tercih edilmiş olup, bu sayede hafif ve kurulumu kolay bir çözüm sağlanmıştır.

Model değişikliklerini takip etmek ve veritabanını güncel tutmak için EF Core Migration sistemi kullanılmıştır. Migration'lar sayesinde tablolar ve alanlar otomatik olarak oluşturulmuş ve güncellenmiştir.



