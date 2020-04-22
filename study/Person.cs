using System;
using System.Collections.Generic;
using System.Text;

namespace study
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string MiddleName { get; } = "";

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }


        public override string ToString() => FirstName + MiddleName + LastName;


        public string AllCaps()=> ToString().ToUpper();

    }
}
