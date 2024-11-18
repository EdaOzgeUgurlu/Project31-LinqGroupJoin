# Project31: LINQ Group Join

## Proje Açıklaması

Bu proje, **C#** programlama dilinde **LINQ (Language Integrated Query)** kullanılarak, öğrenciler ve sınıflar arasında bir "group join" işlemi gerçekleştiren bir uygulamadır.  
Uygulamanın amacı, her sınıfa ait öğrencilerin bir araya getirilmesi ve bu bilgilerin anlamlı bir şekilde ekrana yazdırılmasıdır.

### Problem Tanımı

Bir okul veritabanını temsil eden iki liste tanımlanmıştır:
1. **Öğrenciler Listesi (`students`)**
   - Her öğrenci için benzersiz bir kimlik (`StudentId`), bir isim (`StudentName`) ve ait olduğu sınıfın kimliği (`ClassId`) tanımlanmıştır.

2. **Sınıflar Listesi (`classes`)**
   - Her sınıf için benzersiz bir kimlik (`ClassId`) ve bir isim (`ClassName`) tanımlanmıştır.

**Amaç:**  
Sınıflar ve öğrenciler arasında bir bağlantı kurarak, her sınıf için o sınıfa ait olan öğrencilerin bir grup olarak listelenmesini sağlamaktır.

---

## Kullanılan Teknolojiler

- **Programlama Dili:** C#
- **LINQ (Language Integrated Query):** Veriler üzerinde sorgulama yapmak için kullanılmıştır.
- **.NET Framework/Core:** Konsol uygulaması olarak geliştirilmiştir.

---

## Proje Yapısı

Proje, aşağıdaki dosyalardan ve sınıflardan oluşmaktadır:

### **1. `Classes` Sınıfı**
- **Amaç:** Sınıf bilgilerini temsil eder.
- **Özellikler:**
  - `ClassId`: Sınıfın benzersiz kimliği.
  - `ClassName`: Sınıfın adı.

### **2. `Student` Sınıfı**
- **Amaç:** Öğrenci bilgilerini temsil eder.
- **Özellikler:**
  - `StudentId`: Öğrencinin benzersiz kimliği.
  - `StudentName`: Öğrencinin adı.
  - `ClassId`: Öğrencinin ait olduğu sınıfın kimliği.

### **3. `Program` Sınıfı**
- **Amaç:** Uygulamanın ana akışını ve iş mantığını içerir.
- **Önemli İşlemler:**
  - Öğrenci ve sınıf listelerinin tanımlanması.
  - LINQ kullanılarak "group join" işleminin gerçekleştirilmesi.
  - Elde edilen sonuçların anlamlı bir formatta yazdırılması.

---

## Kod Akışı

### 1. Veri Listelerinin Tanımlanması
```csharp
var students = new List<Student> { ... };
var classes = new List<Classes> { ... };
```
- Öğrenciler ve sınıflar, **`List<T>`** veri yapısı kullanılarak tanımlanır.
- Her öğrenci, bir sınıfa ait olacak şekilde `ClassId` ile ilişkilendirilmiştir.

### 2. LINQ Group Join İşlemi
```csharp
var groupJoinResult = from c in classes
                      join s in students
                      on c.ClassId equals s.ClassId into studentGroup
                      select new
                      {
                          ClassName = c.ClassName,
                          Students = studentGroup
                      };
```
- **Amaç:** Her sınıf için ilgili öğrencilerin gruplanmasını sağlar.
- `into` anahtar kelimesi ile bir `group` oluşturulur.

### 3. Sonuçların Yazdırılması
```csharp
foreach (var item in groupJoinResult)
{
    Console.WriteLine($"Sınıf: {item.ClassName}");
    foreach (var student in item.Students)
    {
        Console.WriteLine($"  - Öğrenci: {student.StudentName}");
    }
}
```
- Her sınıf ve o sınıfa ait öğrenciler, anlamlı bir formatta ekrana yazdırılır.

---

## Çıktı

Aşağıdaki örnek çıktı, kodun çalıştırılmasıyla elde edilir:

```
Sınıflar ve Öğrenciler:
Sınıf: Matematik
  - Öğrenci: Ali
  - Öğrenci: Ayşe
Sınıf: Fizik
  - Öğrenci: Mehmet
  - Öğrenci: Fatma
Sınıf: Kimya
  - Öğrenci: Veli
```

---

## Kullanım

1. Projeyi indirin veya klonlayın:
   ```bash
   git clone https://github.com/kullaniciadi/Project31_LinqGroupJoin.git
   ```
2. Visual Studio veya benzer bir IDE'de açın.
3. Programı derleyin ve çalıştırın.
4. Çıktıyı konsolda görüntüleyin.

---

## Öğrenilenler ve Fayda

- **LINQ Group Join Kullanımı:** Verilerin ilişkisel bir şekilde işlenmesi ve gruplandırılması sağlanmıştır.
- **Nesne Yönelimli Programlama (OOP):** Veri modelleme ile düzenli bir yapı oluşturulmuştur.
- **Konsol Çıktısı Formatlama:** Verilerin kullanıcıya anlamlı bir formatta sunulması gerçekleştirilmiştir.

