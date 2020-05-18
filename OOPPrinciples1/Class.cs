using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class
    {
        private readonly List<Student> students = new List<Student>();
        private readonly List<Teacher> teachers = new List<Teacher>();

        private string name;

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public Class(string name)
        {
            this.name = name;
        }
        public Class AddStudents(params Student[] students)
        {
            foreach (var item in students)
            {
                this.students.Add(item);
            }

            return this;
        }

        public Class AddTeachers(params Teacher[] teachers)
        {
            foreach (var item in teachers)
            {
                this.teachers.Add(item);
            }

            return this;
        }

        public Class RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }

        public Class RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);

            return this;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Class : {this.name}\n");
            result.AppendLine("\nStudents: ");
            foreach (var item in students)
            {
                result.AppendLine(item.ToString());
            }

            result.AppendLine("\nTeachers: ");
            foreach (var item in teachers)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
