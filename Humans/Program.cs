using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Alex","Petrov", 5.35),
                new Student("Iliyan","Dimov", 4.00),
                new Student("Mariya","Ananieva", 5.60),
                new Student("Gabriel","Slavov", 4.70),
                new Student("Ivan","ivanov", 5.50),
                new Student("Nadejda","Nedeva", 5.40),
                new Student("Slavey","Slavov", 3.80),
                new Student("Sonya","Mihova", 4.00),
                new Student("Plamen","Petkov", 5.90),
                new Student("Qna","Qnakieva",3.00)
            };

            var orderByResult = from student in students
                                orderby student.Grade descending
                                select student;

            Console.WriteLine("Order Students by result:");
            foreach (var student in orderByResult)
            {
                Console.WriteLine(student);
            }

            /////////////////////////////////////////////////////////

            Worker[] workers =
            {
                new Worker("Stoyan","Petrov", 950.00),
                new Worker("Milen","Qnev", 1450.50),
                new Worker("Qna","Kaneva", 560.00),
                new Worker("Gosho","ginchev", 800.00),
                new Worker("Ivan","Ivanov", 970.50),
                new Worker("Nadejda","Nonoeva", 455.40),
                new Worker("Slavcho","Slavov", 773.80),
                new Worker("Minka","Moneva", 640.00),
                new Worker("Plamen","Ivanov", 590.90),
                new Worker("Mima","Qnakieva",3000.00)
            };

            var orderBySalary = from worker in workers
                                orderby worker.WeekSalary
                                select worker;

            Console.WriteLine("\nOrder Workers by WeekSalary:");
            foreach (var worker in orderBySalary)
            {
                Console.WriteLine(worker);
            }

            var orderByMoneyPerHour = from worker in workers
                                      orderby worker.MoneyPerHour()
                                      select worker;

            Console.WriteLine("\nOrder Workers by MoneyPerHour:");
            foreach (var worker in orderByMoneyPerHour)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
