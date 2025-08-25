using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Students
{
    public class Student
    {
       public string FirstName { set; get; }
       public string LastName { set; get; }
       public int Age { set; get; }
       public string HomeTown { set; get; }


        public Student ()
        {

        }
        public Student (string firstName, string lastName, int age, string town)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = town;

        }
    }
}
