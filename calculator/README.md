# 🧮 Gelişmiş Hesap Makinesi (Console Calculator)

C# dili kullanılarak geliştirilmiş; temel aritmetik işlemlerin yanı sıra karekök, üs ve mod hesaplamalarını konsol ekranı üzerinden hızlı ve kolay bir şekilde gerçekleştiren bir hesap makinesi uygulamasıdır.

Bu proje; C# programlama dilinin temel mantığını, matematiksel fonksiyonların (`System.Math`) kullanımını, koşullu ifadeleri (if-else / switch-case) ve konsol girdi/çıktı işlemlerini pekiştirmek amacıyla hazırlanmıştır.

## ✨ Özellikler

Uygulama, kullanıcıdan aldığı değerler doğrultusunda aşağıdaki matematiksel işlemleri yapabilir:

- ➕ **Toplama İşlemi** (`+`)
- ➖ **Çıkarma İşlemi** (`-`)
- ✖️ **Çarpma İşlemi** (`*`)
- ➗ **Bölme İşlemi** (`/`)
- 📐 **Üs Hesaplama** (`^`) - _Bir sayının belirtilen kuvvetini hesaplar._
- 🧪 **Mod Bulma** (`%`) - _Bir sayının başka bir sayıya bölümünden kalanını bulur._
- 🧮 **Karekök Alma** (`sqrt`) - _Girilen sayının karekökünü hesaplar._

> **⚠️ Güvenlik Kontrolleri:** > \* Uygulama, matematiksel olarak belirsizlik yaratan **sıfıra bölme hatasını** (`division by zero`) kontrol eder.
>
> - Karekök alma işleminde negatif sayı girilmesi durumunda oluşabilecek hatalara karşı koruma mekanizmasına sahiptir.

## 🛠 Kullanılan Teknolojiler

- **Dil:** C# (Console Application)
- **Framework:** .NET 10.0 (veya .NET Core)

## ⚙️ Gereksinimler

Bu projeyi bilgisayarınızda derlemek ve çalıştırmak için şunların yüklü olması gerekir:

- [.NET SDK](https://dotnet.microsoft.com/download) (Sürüm 6.0 veya üzeri önerilir)
- Herhangi bir kod editörü (Visual Studio, Visual Studio Code veya JetBrains Rider)

## 💻 Kurulum ve Çalıştırma

Projeyi yerel bilgisayarınızda çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. **Projeyi Bilgisayarınıza İndirin:**
   Projeyi GitHub üzerinden klonlamak için terminale şu komutu yazın:
   ```bash
   git clone [https://github.com/kullanici-adi/hesap-makinesi.git](https://github.com/kullanici-adi/hesap-makinesi.git)
   ```
