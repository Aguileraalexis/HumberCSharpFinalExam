using System;

namespace HumberCSharpFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array to hold adult and child 
            Person[] people = new Person[2];

            //intanciating adult and child
            Adult adult = new Adult("AdultFirstName", "AdultLastName");
            Child child = new Child("ChildFirstName", "ChildLastName");

            //populating the array
            people[0] = adult;
            people[1] = child;

            //Output data
            Console.WriteLine("First Name\tLast Name");
            Console.WriteLine("----------\t---------");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.FirstName}\t{person.LastName}");
            }

        }
    }
}
