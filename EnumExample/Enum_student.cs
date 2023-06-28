using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    public enum Streams { CS, IT, Electrical, Electronic, Mach, Civil };
    public class Enum_student
    {
        private int roll_no;
        private string stud_name;
        private double percentage;
        private Streams stream;

        //Default Constructor
        public Enum_student()
        {
            roll_no = 101;
            stud_name = "Sneha";
            percentage = 90;
            stream = Streams.Civil;
        }

        //Parameterized Constructor
        public Enum_student(int no, string name, double perc, Streams stream)
        {
            roll_no = no;
            stud_name = name;
            percentage = perc;
            this.stream = stream;
        }
        public void AcceptStudent(int roll, string name, double perc)
        {
            roll_no = roll;
            stud_name = name;
            percentage = perc;
            
        }

        public string PrintStudent()
        {
            return $"Roll_No is {roll_no}  \nStudent Name is {stud_name} \nPercentage is {percentage} \nStream is {stream}";
        }
    }
}
