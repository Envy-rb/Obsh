﻿using Obsh.service;
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
    public partial class Draft : Form
    {
        public Draft()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBService.getDraft().Tables[0].DefaultView;
        }
    }
}
