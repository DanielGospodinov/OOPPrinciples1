using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class School
    {
        private readonly List<Class> classes = new List<Class>();

        private string name;

        public string Name { get; set; }

        public School(string name)
        {
            this.name = name;
        }
        public School AddClasses(params Class[] classes)
        {
            foreach (var item in classes)
            {
                this.classes.Add(item);
            }

            return this;
        }

        public School RemovaClass(Class _class)
        {
            this.classes.Remove(_class);

            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"School {this.name}\n");

            foreach (var item in classes)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString();
        }
    }
}
