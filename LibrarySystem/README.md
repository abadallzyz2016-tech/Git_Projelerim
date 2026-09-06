# 📚 Library System

Library System, kütüphanelerdeki kitap ve üye işlemlerini yönetmek için geliştirilmiş bir masaüstü kütüphane otomasyon uygulamasıdır.

Proje, **C# Windows Forms** kullanılarak geliştirilmiş ve verilerin saklanması için **Microsoft SQL Server** kullanılmıştır.

---

## 🚀 Proje Hakkında

Bu uygulama ile kütüphanedeki kitaplar ve üyeler yönetilebilir.

Sistem üzerinden;

- 📚 Kitap ekleme
- 🗑️ Kitap silme
- 🔎 Kitap arama
- 👤 Üye ekleme
- 🗑️ Üye silme
- 📋 Üyeleri listeleme
- 📖 Kitap ödünç verme
- 🔄 Kitap iade alma
- 🔍 Üyenin aldığı kitapları kontrol etme
- 📊 Kitap ve üye bilgilerini görüntüleme

işlemleri gerçekleştirilebilir.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| C# | Uygulama geliştirme |
| .NET | Uygulama altyapısı |
| Windows Forms | Kullanıcı arayüzü |
| SQL Server | Veritabanı |
| ADO.NET | C# - SQL Server bağlantısı |
| Visual Studio | Geliştirme ortamı |
| Git / GitHub | Versiyon kontrolü |

---

## 🗂️ Proje Yapısı

Proje içerisinde temel olarak aşağıdaki yapı kullanılmaktadır:

```text
LibrarySystem
│
├── Forms
│   ├── MainForm.cs
│   ├── Add_Book.cs
│   ├── Delete_Book.cs
│   ├── Add_Member.cs
│   ├── Delete_Member.cs
│   ├── BorrowBook.cs
│   ├── ReturnBook.cs
│   ├── ListBooks.cs
│   ├── ListMember.cs
│   ├── LoanHistory.cs
│   ├── BooksOnLoan.cs
│   └── SearchBook.cs
│
│
├── Models
│   ├── Book.cs
│   ├── Member.cs
│   ├── BorrowBook.cs
│   └── ReturnBook.cs
│
├── Services
│   ├── LibraryService.cs
│   ├── BookService.cs
│   └── MemberService.cs
│
│
└── Program.cs
```

---

## 🎯 Projenin Amacı

Bu projenin temel amacı gerçek hayattaki bir kütüphane sisteminin temel işleyişini yazılım ortamında modellemektir.

Proje geliştirilirken özellikle;

C# programlama
Nesne yönelimli programlama
Windows Forms
SQL Server
ADO.NET
CRUD işlemleri
SQL sorguları
Primary Key / Foreign Key
Veritabanı ilişkileri
Parametreli SQL sorguları
Exception Handling
Katmanlı yapı

konularında pratik yapılması hedeflenmiştir.

---

## 📈 Gelecekte Eklenebilecek Özellikler

Projeye ilerleyen aşamalarda aşağıdaki özellikler eklenebilir:

📊 İstatistik ve raporlama sistemi
⏰ Geciken kitapların tespit edilmesi
📅 Son iade tarihinin belirlenmesi
🔔 Gecikme uyarıları
📚 Kategori bazlı kitap filtreleme
🔐 Kullanıcı giriş sistemi
👨‍💼 Admin paneli
📈 Dashboard
📝 Ödünç alma geçmişi
🗃️ Soft delete sistemi
🔄 Veritabanı transaction yönetimi

---

## 🧠 Öğrenilen Konular

C#
├── Classes
├── Methods
├── Parameters
├── Return Values
├── Exception Handling
└── Windows Forms

SQL
├── SELECT
├── INSERT
├── UPDATE
├── DELETE
├── WHERE
├── JOIN
├── COUNT
├── PRIMARY KEY
└── FOREIGN KEY

ADO.NET
├── SqlConnection
├── SqlCommand
├── SqlDataReader
├── ExecuteNonQuery()
├── ExecuteScalar()
└── Parameters

---

## 👨‍💻 Geliştirici

Abdulaziz Aea

C# ve SQL Server kullanılarak geliştirilmiştir.