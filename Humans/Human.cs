using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public abstract class Human
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        public string FirtstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public abstract override string ToString();
    }
}
