using Obsh.entity;
using Obsh.parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.service
{
    class StudentService
    {
        public static List<Student> parseStudents(DataSet input)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow row in input.Tables[0].Rows)
            {
                students.Add(StudentParser.parseStudent(row[1].ToString(), row[2].ToString(), row[3].ToString()));
            }
            return students;
        }
    }
}
