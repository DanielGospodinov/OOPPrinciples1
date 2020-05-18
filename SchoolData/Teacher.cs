using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolData
{
    class Teacher : Human
    {
        private readonly List<Discipline> disciplines = new List<Discipline>();
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {

        }

        public Teacher AddDiscipline(params Discipline[] numbOfDisciplines)
        {
            foreach (var item in numbOfDisciplines)
            {
                this.disciplines.Add(item);
            }

            return this;
        }

        public Teacher RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);

            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"*** {base.FirtstName} {base.LastName}.");
            foreach (var item in this.disciplines)
            {
                result.AppendLine($"Discipline : {item.ToString()}");
            }

            return result.ToString();
        }
    }
}
