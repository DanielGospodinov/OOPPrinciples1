using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Student : Human
    {
        double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            set { this.grade = value; }
            get { return this.grade; }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{base.FirtstName} {base.LastName} -- Grade : {this.grade:F2}");
            return result.ToString();
        }
    }
}
