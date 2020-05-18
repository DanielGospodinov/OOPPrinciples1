using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School("TU-Sofia");

            Discipline[] disciplines = new Discipline[]
            {
                new Discipline("C#",30,25),
                new Discipline("Java",28,25),
                new Discipline("C++",28,30),
                new Discipline("Phyton",28,28),
                new Discipline("JavaScript",25,20),
                new Discipline("SQL",32,25)
            };

            Student[] students = new Student[]
            {
                new Student("Ivan","Petrov",1),
                new Student("Mihail","Krasimirov",2),
                new Student("Ralica","Ivanova",3),
                new Student("Zahari","Milanov",4),
                new Student("Petyr","Petrov",5),
                new Student("Simeon","Slavov",6)
            };

            Teacher[] teachers = new Teacher[]
            {
                new Teacher("Nikolay","Nedelev").AddDiscipline(disciplines[0],disciplines[1]),
                new Teacher("Ivan","Ivanov").AddDiscipline(disciplines[2],disciplines[3]),
                new Teacher("Milen","Mihov").AddDiscipline(disciplines[4],disciplines[5])
            };

            Class class1 = new Class("Class A");
            class1.AddTeachers(teachers);
            class1.AddStudents(students);

            school.AddClasses(class1);

            Console.WriteLine(school.ToString());
        }
    }
}
