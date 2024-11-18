using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project31_LinqGroupJoin
{
    // Bu sınıf, Classes tablosunu temsil eder. 
    // Sınıf verileriyle çalışmak için bir model tanımlıyoruz.
    // Bu model, sınıfların ID'si ve isimleri gibi özellikleri barındırır.

    internal class Classes
    {
        // Bu özellik, sınıfın kimliğini (ID) temsil eder.
        public int ClassId { get; set; }

        // Bu özellik, sınıfın adını (örneğin, "Matematik", "Fizik") tutar.
        public string ClassName { get; set; }
    }
}








