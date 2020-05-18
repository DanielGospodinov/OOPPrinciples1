using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Discipline
    {
        private string name;
        private uint numbLectures;
        private uint numbExercises;

        public Discipline(string name, uint numbLectures, uint numbExrcicses)
        {
            this.name = name;
            this.numbLectures = numbLectures;
            this.numbExercises = numbExrcicses;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public uint NumbExercises
        {
            set { this.numbExercises = value; }
            get { return this.numbExercises; }
        }
        public uint NumbLectures
        {
            set { this.numbLectures = value; }
            get { return this.numbLectures; }
        }

        public override string ToString()
        {
            string result = String.Format($"{this.Name} (Exrecices : {this.NumbExercises}, Lections : {this.NumbLectures}) ");
            return result;
        }
    }
}
