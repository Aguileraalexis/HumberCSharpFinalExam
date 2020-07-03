using System;
using System.Collections.Generic;
using System.Text;

namespace HumberCSharpFinalExam
{
    class Adult : Person
    {

        public Adult(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

}
