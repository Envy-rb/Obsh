using Obsh.entity;
using Obsh.service;
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
    public partial class AddStudentForm : Form
    {
        Student student;
        List<Room> rooms;
        public AddStudentForm(List<Room> rooms)
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
            RoomBox.DataSource = freerooms;
            RoomBox.ValueMember = "Number";
        }

        public void getStudent()
        {
            student = new Student(nameBox.Text, surnameBox.Text, midNameBox.Text);
            Room sel = (Room)RoomBox.SelectedItem;
            sel.addStudent(student);
            DBService.writeDraft(sel, student);
            var form = new DraftForm(student, sel);
            form.ShowDialog(this);
        }

        private void ok_Click(object sender, EventArgs e)
        {

        }
    }
}
