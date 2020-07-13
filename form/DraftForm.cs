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
    public partial class DraftForm : Form
    {
        public DraftForm(Student student, Room room)
        {
            InitializeComponent();
            label2.Text = student.ToString();
            label4.Text = room.Number.ToString();
            label6.Text = DateTime.Now.ToShortDateString();
            label8.Text = room.Price.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
