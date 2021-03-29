using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
             var s = new Student("Alex", new Knowledge(5));
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", new Knowledge(4)));
            university.AddStudent(new Student("Julia Veselkina"));
            university.AddStudent(new Student("Maria Perechrest"));
            university.AddStudent(s);

            Internship internship = new Internship("Interlink");
            //internship.AddStudents(university.Students);


            internship.AddStudentsFromOtherEducPlace(university); // поліморфізм

            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
