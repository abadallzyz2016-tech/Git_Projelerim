# Unit Converter

C# ve Windows Forms kullanılarak geliştirilmiş, farklı ölçü birimleri arasında dönüşüm yapmayı sağlayan bir **Birim Dönüştürücü** uygulamasıdır.

Bu proje; C# temel bilgilerini, Windows Forms kullanımını, fonksiyon tasarımını, kullanıcıdan veri almayı ve hesaplama işlemlerini öğrenmek amacıyla geliştirilmiştir.

---

## Projenin Amacı

Kullanıcının farklı ölçü birimleri arasında kolayca dönüşüm yapabilmesini sağlamak.

Uygulamada farklı kategoriler altında birçok birim dönüşümü bulunmaktadır.

---

## Özellikler

### Uzunluk Birimleri

### Alan Birimleri

## Hacim Birimleri

### Ağırlık Birimleri

### Sıcaklık Birimleri

### Hız Birimleri

### Zaman Birimleri

### Veri Birimleri

---

## Kullanılan Teknolojiler

* **C#**
* **.NET**
* **Windows Forms**
* **Visual Studio**

---

## Proje Yapısı

```text
UnitConverter/
│
├── UnitConverter/
│   │
│   ├── Dependencies/
│   │
│   ├── Forms/
│   │   └── MainForm.cs
│   │
│   ├── Services/
│   │   ├── Transformations.cs
│   │ 
│   └── Program.cs
│
└── README.md
```

---

## Uygulamanın Çalışma Mantığı

Uygulamanın genel çalışma mantığı:

```text
Kullanıcı
    ↓
MainForm
    ↓
Kategori Seçimi
    ↓
Kaynak Birim Seçimi
    ↓
Hedef Birim Seçimi
    ↓
Değer Girme
    ↓
İlgili Converter
    ↓
Hesaplama
    ↓
Sonucu Göster
```

---

## Projenin Amaçladığı Kazanımlar

Bu proje ile aşağıdaki konularda pratik yapılması amaçlanmaktadır:

* C# programlama
* Windows Forms
* Fonksiyon/metot tasarımı
* Parametre kullanımı
* `return` kullanımı
* Matematiksel işlemler
* `if-else` yapıları
* `ComboBox` kullanımı
* Kullanıcıdan veri alma
* Veri doğrulama
* Nesne oluşturma
* Sınıflar arası sorumluluk dağılımı
* Kodun parçalara ayrılması
* Temiz ve okunabilir kod yazma
* Git ve GitHub kullanımı

---

## Gelecekte Eklenebilecek Özellikler

Proje ilerleyen aşamalarda aşağıdaki özelliklerle geliştirilebilir:

* Basınç birimleri
* Enerji birimleri
* Güç birimleri
* Yakıt tüketimi birimleri
* Para birimi dönüştürme
* Dönüşüm geçmişi
* Favori dönüşümler
* Birim arama sistemi
* Karanlık / aydınlık tema
* Daha gelişmiş giriş doğrulama sistemi

---

## Projeyi Çalıştırma

### 1. Projeyi Klonlama

```bash
git clone <repository-url>
```

### 2. Projeyi Açma

Projeyi **Visual Studio** ile açın.

`.sln` veya `.csproj` dosyasını açabilirsiniz.

### 3. Projeyi Derleme

Visual Studio üzerinden:

```text
Build → Build Solution
```

veya:

```text
Ctrl + Shift + B
```

kısayolunu kullanabilirsiniz.

### 4. Uygulamayı Çalıştırma

```text
F5
```

veya:

```text
Ctrl + F5
```

kısayollarından biri kullanılabilir.

---

## Lisans

Bu proje eğitim ve kişisel gelişim amacıyla geliştirilmiştir.

---

## Geliştirici

**Abdulaziz Aea
