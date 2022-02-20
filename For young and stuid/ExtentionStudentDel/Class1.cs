using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDelExt
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { FirstName = "Александр", LastName = "Антипов" };

            Console.WriteLine(student.GetFulName());
        }
    }
}
