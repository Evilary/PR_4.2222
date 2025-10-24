using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Чернышков2.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Schoolarship = false;
        public int Course = 4;

        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }

        public Student(string Firstname, string Lastname, string Surname, bool Schoolarship) 
            : this(Firstname,Lastname,Surname) {
            this.Schoolarship = Schoolarship;
        }

        public Student(string Firstname, string Lastname, string Surname, bool Schoolarship, int Course)
            : this(Firstname, Lastname, Surname, Schoolarship)
        {
            this.Course = Course;
        }

        public string GetFIO()
        {
            return $"{Lastname}{Firstname}{Surname}";
        }

    }
}
