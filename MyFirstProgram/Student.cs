using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    public class Student
    {
       public Student(string phnNumber) { 

            PhoneNumber = phnNumber;
        }

        public string Id;

        public string Name;

        public int Age;

        public string Dob;

        public char Sex;

        private string PhoneNumber;

        //string CountryCode { get; }

        public void ShowPhoneNumber()
        {
            Console.WriteLine(PhoneNumber);
        }

        //Adding new comment
    }
}
