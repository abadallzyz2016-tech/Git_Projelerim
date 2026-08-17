# 🎓 Student Management System

C# ve Windows Forms kullanılarak geliştirilmiş bir **Öğrenci Yönetim Sistemi** uygulamasıdır.

Bu proje; öğrenci ekleme, güncelleme, silme, listeleme, toplu veri silme ve öğrenci notlarına göre sıralama gibi temel öğrenci yönetimi işlemlerini gerçekleştirmek amacıyla geliştirilmiştir.

Ayrıca proje içerisinde dosya işlemleri, OOP, `List<T>`, LINQ, `DataGridView`, `StreamReader`, `StreamWriter`, `File` sınıfı, exception handling ve otomatik ID oluşturma gibi C# konuları uygulanmıştır.

---

## 🚀 Proje Özellikleri

### 👨‍🎓 Öğrenci Yönetimi

- Öğrenci ekleme
- Öğrenci silme
- Öğrenci güncelleme
- Öğrenci listeleme
- Öğrenci ID'sine göre öğrenci arama
- Ortalama notuna göre sıralama
- Tüm öğrencileri silme
- Öğrenci bilgilerinin DataGridView üzerinde gösterilmesi
- Sahte öğrenci verisi oluşturma
- ID sistemi

---

### ➕ Öğrenci Ekleme

Yeni öğrenci oluşturulurken aşağıdaki bilgiler alınır:

- ID
- Name
- Surname
- Age
- Sex
- Department
- Average

Öğrenci ID'si kullanıcı tarafından girilmez.

Sistem, `StudentData.txt` içerisindeki mevcut en yüksek ID'yi bulur ve yeni öğrenci için:

```text
Yeni ID = En yüksek ID + 1
```

---

### ✏️ Öğrenci Güncelleme

Student ID: 15

## Current Information

Name: ALI
Surname: YILMAZ
Age: 21
Sex: MALE
Department: SOFTWARE ENGINEER
Average: 78.500

## New Information

Name: AHMET
Surname: YILMAZ
Age: 22
Sex: MALE
Department: COMPUTER ENGINEER
Average: 85.750

---

### 🗑️ Öğrenci Silme

Öğrenci ID'si kullanılarak belirli bir öğrenci bulunabilir ve silinebilir.

Silme işlemi sırasında:

1- Öğrenci ID'si aranır.
2- Öğrenci bulunursa bilgileri görüntülenir.
3- Öğrenci silinir.
4- Dosya yeniden kaydedilir.

---

### 🗑️ Tüm Öğrencileri Silme

Silme işleminden önce kullanıcıdan onay alınır.

Örneğin:

Are you sure you want to delete all student data?

[ YES ] [ NO ]

İşlem sonrasında dosyanın başlık satırı korunur:

ID | NAME | SURNAME | AGE | SEX | DEPARTMENT | AVERAGE

Öğrenci verileri silinir.

---

### 📋 Student List

Öğrenciler DataGridView kullanılarak listelenir.

| ID  | Name  | Surname | Age | Sex  | Department        | Average |
| --- | ----- | ------- | --- | ---- | ----------------- | ------- |
| 1   | ALI   | YILMAZ  | 20  | MALE | SOFTWARE ENGINEER | 85.500  |
| 2   | AHMET | KAYA    | 21  | MALE | COMPUTER ENGINEER | 72.300  |

DataGridView Özellikleri

## DataGridView aşağıdaki özelliklere sahiptir:

Kullanıcı tarafından veri değiştirilemez.
Satırın tamamı seçilebilir.
Aynı anda yalnızca bir öğrenci seçilebilir.
Kullanıcı yeni satır ekleyemez.
Kullanıcı satır silemez.
Satır başlıkları gizlidir.
Kolonlar DataGridView genişliğine göre ayarlanır.
Öğrenci bilgileri otomatik olarak listelenir.

---

### 📊 Not Sıralama

Öğrenciler Average değerlerine göre yüksekten düşüğe sıralanabilir.

## Linq kullanılarak

students = students
.OrderByDescending(student => student.Average)
.ToList();

Örneğin:
ID NAME AVERAGE

---

15 AHMET 98.500
7 MEHMET 94.250
3 ALI 87.750
21 HASAN 75.500
8 OSMAN 62.300

---

### 🧪 Fake Student Data

Proje içerisinde test amacıyla otomatik öğrenci verileri oluşturulabilmektedir.

FakeData kullanılarak:

İsim
Soyisim
Yaş
Cinsiyet

gibi bilgiler otomatik oluşturulur.

---

### 📁 Veri Saklama

Proje verileri bir TXT dosyasında saklanmaktadır.

Dosya:

Data/StudentData.txt

Örnek veri:

ID | NAME | SURNAME | AGE | SEX | DEPARTMENT | AVERAGE
1 | ALI | YILMAZ | 20 | MALE | SOFTWARE ENGINEER | 85.500
2 | AHMET | KAYA | 21 | MALE | COMPUTER ENGINEER | 72.300
3 | AYŞE | DEMİR | 19 | FEMALE | MEDICAL | 91.200

---

### 💾 Kullanılan Dosya İşlemleri

Projede C# dosya işlemleri kullanılmıştır.

StreamReader
StreamWriter
File.WriteAllText
File.WriteAllLines

---

### 🧱 OOP Kullanımı

### 📦 List<T> Kullanımı

### 🔍 Öğrenci Arama

### 🆔 ID Sistemi

### 🛡️ Veri Kontrolleri

### 🔢 Average Formatı

### 🧹 String Temizleme

### ⚠️ Exception Handling

### 🖥️ Windows Forms

---

### 📂 Proje Yapısı

StudentManagementSystem
├── Dependencies
├── Properties
├── Data
│ └── StudentData.txt
├── Forms
│ ├── AverageRatingForm.cs
│ ├── MainForm.cs
│ ├── StudentAddForm.cs
│ ├── StudentDeleteForm.cs
│ ├── StudentListForm.cs
│ ├── StudentSearchForm.cs
│ └── StudentUpdateForm.cs
├── Helpers
├── Models
│ └── Student.cs
├── Resources
│ ├── averagerating.jpg
│ ├── exit.png
│ ├── idsystem.png
│ ├── studentadd.jpg
│ ├── studentdelete.jpg
│ ├── studentlist.png
│ ├── studentsearch.png
│ └── studentupdate.png
├── Services
│ ├── FileService.cs
│ └── StudentService.cs
└── Program.cs

---

### 📌 Öğrenilen C# Konuları

Bu proje geliştirilirken aşağıdaki konular uygulanmıştır:

Classes
Objects
Properties
Methods
OOP
List<T>
Loops
Conditional Statements
String Operations
Trim()
ToUpper()
TryParse()
Math.Truncate()
Random
File Operations
StreamReader
StreamWriter
File.WriteAllText()
File.WriteAllLines()
File.Exists()
Exception Handling
try-catch
throw
LINQ
OrderByDescending()
Windows Forms
DataGridView
TextBox
ComboBox
MessageBox
Form Events
Form Navigation

---

🔮 Gelecekte Eklenebilecek Özellikler

Proje ilerleyen aşamalarda aşağıdaki özelliklerle geliştirilebilir:

🔎 Öğrenci arama
🔤 İsme göre sıralama
📈 Grafikler
🔐 Kullanıcı giriş sistemi
👥 Kullanıcı yetkilendirme
🗄️ SQL Server / MySQL veritabanı desteği
📤 Excel'e aktarma
📄 PDF raporu oluşturma
🔄 DataGridView otomatik yenileme
🌙 Dark Mode
🔍 Gelişmiş filtreleme
📱 Daha modern kullanıcı arayüzü

---

### ▶️ Projeyi Çalıştırma

1. Repository'yi klonla
2. Projeyi Visual Studio ile aç
3. Gerekli NuGet paketlerini yükle
4. Projeyi çalıştır

---

### 👨‍💻 Geliştirici

Abdulaziz

Student Management System
C# / .NET / Windows Forms
