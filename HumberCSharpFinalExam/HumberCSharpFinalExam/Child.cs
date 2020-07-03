using System;
using System.Collections.Generic;
using System.Text;

namespace HumberCSharpFinalExam
{

    class Child : Person
    {

        public Child(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
