# 🏧 ATM Simülasyonu

C# ve Windows Forms kullanılarak geliştirilmiş, temel ATM işlemlerini simüle eden masaüstü uygulaması.

Bu proje; kullanıcı girişi, para çekme, para yatırma, para transferi ve işlem geçmişi gibi temel bankacılık işlemlerini gerçekleştirebilen bir ATM sistemi oluşturmak amacıyla geliştirilmiştir.


---

## 📌 Proje Hakkında

ATM Simülasyonu, kullanıcıların bir ATM üzerinden gerçekleştirebileceği temel bankacılık işlemlerini Windows Forms arayüzü üzerinden gerçekleştirmesini sağlar.

Kullanıcı sisteme giriş yaptıktan sonra kendisine ait hesap bilgilerine erişebilir ve aşağıdaki işlemleri gerçekleştirebilir:

- 💰 Para çekme
- 💵 Para yatırma
- 🔄 Para transferi
- 📜 İşlem geçmişini görüntüleme
- 💳 Bakiye görüntüleme
- 🚪 Oturumdan çıkış

Kullanıcıya ait bilgiler ve bakiye verileri `.txt` dosyalarında saklanmaktadır.

---

# ✨ Özellikler

## 🔐 Kullanıcı Girişi

Sisteme kayıtlı kullanıcılar kullanıcı adı ve şifreleri ile giriş yapabilir.

Giriş sırasında:

- Kullanıcı adı kontrol edilir.
- Şifre kontrol edilir.
- Hatalı bilgilerde kullanıcıya uyarı gösterilir.
- Başarılı giriş sonrasında Main Menu ekranı açılır.
- Giriş yapan kullanıcının Account ID bilgisi diğer formlara aktarılır.

---


## 🏠 Ana Menü

Başarılı giriş sonrasında kullanıcı Main Menu ekranına yönlendirilir.

Ana menü üzerinde kullanıcının:

- 👤 Adı
- 💳 Account ID
- 💰 Mevcut bakiyesi
- 💵 Deposit
- 💸 Withdraw
- 🔄 Transfer
- 📜 History

gibi işlemlere erişebilmesi sağlanır.

---

# 💸 Withdraw - Para Çekme

Kullanıcı hesabındaki mevcut bakiyeden para çekebilir.

### Özellikler

- Mevcut bakiye görüntülenir.
- Kullanıcının çekmek istediği miktar alınır.
- Belirlenen hızlı miktarlar kullanılabilir.
- Özel bir miktar girilebilir.
- Yetersiz bakiye kontrolü yapılır.
- Geçersiz miktar kontrolü yapılır.
- Para çekme işleminden sonra bakiye güncellenir.
- İşlem History dosyasına kaydedilir.

### Örnek

```text
Mevcut Bakiye: 5000 TL

Çekilen: 1000 TL

Yeni Bakiye: 4000 TL
```

---

### Not !!!!

Programı bilgisayarınızda sorunsuz bir şekilde çalıştırmak için github üzerinden projeyi kopyaladıktan sonra dosyaların kaydedildiği sürücüleri değiştirmeniz gerekiyor aksi takdirde hata alırsınız. 
