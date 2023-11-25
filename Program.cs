using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStudent
{
    internal class Program : Student
    {
        
        static void Main(string[] args)
        {

            Student student1 = new Student("", 0, 0, "", 0, 0, 0);
            student1.Registrate();
            student1.GetName();
            student1.GetAge();
            student1.GetGender();
            student1.ShowData();
            student1.None();
            student1.PrintCommand();
            

            Console.ReadKey();
        }
        
    }

}
