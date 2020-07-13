using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obsh.entity
{
    public class Room
    {
        private int number;
        private int capacity;
        private double price;
        private List<Student> students = new List<Student>();

        public Room(int number, int capacity, double price)
        {
            this.number = number;
            this.capacity = capacity;
            this.price = price;
        }

        public Room(int number, int capacity, double price, List<Student> students) : this(number, capacity, price)
        {
            this.students = students;
        }

        public int Number => number;
        public int Capacity => capacity;
        public double Price => price;

        internal List<Student> Students { get => students; set => students = value; }

        public void addStudent(Student student)
        {
            if (this.Free())
            {
                students.Add(student);
            }
        }

        public void removeStudent(int index)
        {
            students.RemoveAt(index);
        }

        public void removeStudent(Student student)
        {
            students.Remove(student);
        }

        public bool Free()
        {
            return students.Count() < capacity;
        }
    }
}
