using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project31_LinqGroupJoin
{
    // Bu sınıf, Student (Öğrenci) tablosunu temsil eder.
    // Her öğrenciye ait bilgiler, bu sınıfın özelliklerinde saklanır.
    // Bu yapı, öğrenci verileriyle çalışmayı kolaylaştırmak için kullanılır.

    internal class Student
    {
        // Bu özellik, her öğrencinin benzersiz kimliğini (ID) temsil eder.
        public int StudentId { get; set; } 

        // Bu özellik, öğrencinin adını tutar.
        public string StudentName { get; set; } 
        public int ClassId { get; set; } 

    }
}
