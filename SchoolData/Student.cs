using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolData
{
    public class Student : Human
    {
        private int classNumber;

        public Student(string firstName, string lastName, int classNumber) : base(firstName, lastName)
        {
            this.classNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }
        public override string ToString()
        {
            string result = String.Empty;
            result = String.Format($"{this.classNumber}. {this.FirtstName} {this.LastName} ");
            return result;
        }
    }
}
