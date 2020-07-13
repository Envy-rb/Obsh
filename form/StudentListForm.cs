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
    public partial class StudentListForm : Form
    {
        int globalIndex = -1;
        public StudentListForm(int index)
        {
            InitializeComponent();
            globalIndex = index;
            dataGridView1.DataSource = StudentDBService.getStudentsFromRoom(index).Tables[0].DefaultView;
        }

        public StudentListForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = StudentDBService.getStudents().Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index;

            index = int.Parse(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            StudentDBService.queryRemove(index);
            dataGridView1.DataSource = null;
            if (globalIndex == -1)
            {
                dataGridView1.DataSource = StudentDBService.getStudents().Tables[0].DefaultView;
            }
            else
            {
                dataGridView1.DataSource = StudentDBService.getStudentsFromRoom(globalIndex).Tables[0].DefaultView;
            }
        }
    }
}
