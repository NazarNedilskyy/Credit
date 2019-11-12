using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            class1.Name = "Ivan"; class1.balans = 100;
            Console.WriteLine($"Name:{class1.Name} balans:{class1.balans}");
        }
    }
}
