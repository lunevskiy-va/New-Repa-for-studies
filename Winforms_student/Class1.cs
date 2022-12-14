using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms_student
{
    public class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string group { get; set; }
        public DateOnly birthday { get; set; }

        public Student(string firstname, string lastname, string group, DateOnly birthday)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.group = group;
            this.birthday = birthday;
        }

        public override string ToString()
        {
            return $"Имя {firstname}\n Фамилия {lastname}\n Группа {group}\n Дата рождения {birthday}";
        }
    }
}
