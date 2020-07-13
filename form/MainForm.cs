using Obsh.entity;
using Obsh.form;
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

namespace Obsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            var form = new RoomForm();
            form.Show(this);
        }

        private void StudentButtom_Click(object sender, EventArgs e)
        {
            var form = new StudentListForm();
            form.Show(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"resource/Help/help.chm");
        }
    }
}
