using Obsh.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.parser
{
    class StudentParser
    {
        public static Student parseStudent(string name, string surname, string midname)
        {
            Student result;

            result = new Student(name, surname, midname);
            return result;
        }
    }
}
