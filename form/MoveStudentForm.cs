using Obsh.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsh.form
{
    public partial class MoveStudentForm : Form
    {
        List<Room> rooms;
        public MoveStudentForm(List<Room> rooms)
        {
            InitializeComponent();
            this.rooms = rooms;
            List<Room> freerooms = new List<Room>();
            foreach (var room in rooms)
            {
                if (room.Free())
                {
                    freerooms.Add(room);
                }
            }
            RoomsBox.DataSource = rooms;
            RoomsBox.ValueMember = "Number";

            FreeRoomsBox.DataSource = freerooms;
            FreeRoomsBox.ValueMember = "Number";
        }

        private void updateStudents()
        {
            StudentBox.Items.Clear();
            Room selectedRoom = (Room)RoomsBox.SelectedItem;
            foreach (var student in selectedRoom.Students)
            {
                StudentBox.Items.Add(student.Surname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Room room1 = (Room)RoomsBox.SelectedItem;
            Room room2 = (Room)FreeRoomsBox.SelectedItem;

            room2.addStudent(room1.Students[StudentBox.SelectedIndex]);
            room1.removeStudent(StudentBox.SelectedIndex);

            Close();
        }

        private void RoomsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStudents();
        }
    }
}
