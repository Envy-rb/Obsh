using Obsh.entity;
using Obsh.parser;
using Obsh.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obsh.form
{
    public partial class RoomForm : Form
    {
        RoomService roomService = new RoomService();
        public RoomForm()
        {
            InitializeComponent();
            roomService.parseRooms();
            DBService.writeDB(roomService.rooms);
            dataGridView1.DataSource = RoomDBService.getRooms().Tables[0].DefaultView;
        }

        private void StudentsInRoom_Click(object sender, EventArgs e)
        {
            int index;
            DataRow row = RoomDBService.getRooms().Tables[0].Rows[dataGridView1.SelectedCells[0].RowIndex];
            index = int.Parse(row[0].ToString());
            var form = new StudentListForm(index);
            form.ShowDialog(this);
            roomService.parseRooms();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var form = new AddStudentForm(roomService.rooms);
            DialogResult dr = form.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                form.getStudent();
            }
            DBService.writeDB(roomService.rooms);
        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var form = new AddRoomForm();
            DialogResult dr = form.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                roomService.rooms.Add(form.getRoom());
            }
            DBService.writeDB(roomService.rooms);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RoomDBService.getRooms().Tables[0].DefaultView;
        }

        private void EditRoomButton_Click(object sender, EventArgs e)
        {
            var form = new MoveStudentForm(roomService.rooms);
            form.ShowDialog(this);
            DBService.writeDB(roomService.rooms);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RoomDBService.getRooms().Tables[0].DefaultView;
        }

        private void RemoveRoomButton_Click(object sender, EventArgs e)
        {
            int index;

            index = int.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            RoomDBService.queryRemove(index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RoomDBService.getRooms().Tables[0].DefaultView;
            roomService.parseRooms();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new Draft();
            form.Show(this);
        }

    }
}
