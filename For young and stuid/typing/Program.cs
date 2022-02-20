using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typing
{
    class Student
    {
        public Student(string lastName, DateTime birthday)
        {
            _lastName = lastName;
            _birthday = birthday;
        }

        public Student(string lastName, string firstName, string middleName, DateTime birthday):this(lastName, birthday)
        {
            _lastName = lastName;
            _firstName = firstName;
            _middleName = middleName;
            _birthday = birthday;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        private string _firstName;
        private string _middleName;
        private string _lastName;
        private DateTime _birthday;

        public void Print()
        {
            Console.WriteLine($"Имя: {_firstName} \nФамилия: {_lastName}\nОтчество: {_middleName}\nДата рождения: {_birthday}");
        }





    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Антипов", new DateTime(1999, 05, 25));
            Student student2 = new Student(firstName:"Елена",lastName:"Попова", middleName:"Андреевна", birthday : new DateTime(1999, 07, 26));

            student2.Print();

        }
    }
}
