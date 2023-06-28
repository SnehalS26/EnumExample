using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enum_employee emp1 = new Enum_employee("Rajesh", 24000, Dept.Sales);
            emp1.CalculateSalary();
            Console.WriteLine(emp1);

            Enum_employee emp2 = new Enum_employee("Amol", 34000, Dept.Testing);
            emp2.CalculateSalary();
            Console.WriteLine(emp2);

            Console.WriteLine("*========================================================================================================*");

            Enum_student student1 = new Enum_student();
            Console.WriteLine(student1.PrintStudent());

        }
    }
}
