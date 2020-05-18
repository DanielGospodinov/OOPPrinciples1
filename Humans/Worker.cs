using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Worker : Human
    {
        public double WeekSalary { get; set; }
        const int weekHours = 40;

        public Worker(string firstName, string lastName, double weekSalary) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
        }

        public double MoneyPerHour()
        {
            return (this.WeekSalary / weekHours);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{base.FirtstName} {base.LastName} \n WeekSalary : {this.WeekSalary} , MoneyPerHour : {this.MoneyPerHour()}");

            return result.ToString();
        }
    }
}
