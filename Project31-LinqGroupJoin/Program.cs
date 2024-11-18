using Project31_LinqGroupJoin; 
using System;
using System.Collections.Generic; 
using System.Linq; 

class Program
{
    static void Main(string[] args)
    {
        #region Veri Listesi Oluşturma

        // Öğrenci listesi oluşturuluyor
        var students = new List<Student>
        {
            new Student { StudentId = 1, StudentName = "Ali", ClassId = 1 },
            new Student { StudentId = 2, StudentName = "Ayşe", ClassId = 1 },
            new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 2 },
            new Student { StudentId = 4, StudentName = "Fatma", ClassId = 2 },
            new Student { StudentId = 5, StudentName = "Veli", ClassId = 3 }
        };

        // Sınıf listesi oluşturuluyor
        var classes = new List<Classes>
        {
            new Classes { ClassId = 1, ClassName = "Matematik" },
            new Classes { ClassId = 2, ClassName = "Fizik" },
            new Classes { ClassId = 3, ClassName = "Kimya" }
        };

        // Bu veri listeleri, LINQ sorguları üzerinde işlem yapmak ve ilişkisel bir yapı kurmak için temel oluşturur.

        #endregion

        #region LINQ Sorgusu ile Group Join 

        // Group Join, her sınıfın altına o sınıfa ait olan öğrencileri gruplamak için kullanılır.
        var groupJoinResult = from c in classes
                              join s in students
                              on c.ClassId equals s.ClassId into studentGroup // Sınıflara ait öğrenciler gruplandı
                              select new
                              {
                                  ClassName = c.ClassName, // Sınıf adı 
                                  Students = studentGroup  // Sınıfa ait öğrenciler listesi
                              };

        #endregion

        #region Sonuçların Yazdırılması

        // Her sınıf için, o sınıfa ait öğrencilerin isimleri yazdırılıyor.
        Console.WriteLine("Sınıflar ve Öğrenciler:");
        foreach (var item in groupJoinResult) 
        {
            Console.WriteLine($"Sınıf: {item.ClassName}"); // Sınıf adı yazdırılıyor
            foreach (var student in item.Students) // Sınıfa ait öğrenciler yazdırılıyor
            {
                Console.WriteLine($"  - Öğrenci: {student.StudentName}"); // Öğrenci adı
            }
        }


        #endregion
    }
}