using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.entity
{
    public class Student
    {
        private string name;
        private string surname;
        private string midname;

        public Student(string name, string surname, string midname)
        {
            this.name = name;
            this.surname = surname;
            this.midname = midname;
        }

        public string Name => name;
        public string Surname => surname;
        public string Midname => midname;

        public override string ToString()
        {
            string result;
            result = string.Format("Фамилия:{0} , Имя :{1} , Отчество: {2}", name, surname, midname);
            return result;
        }
    }
}
