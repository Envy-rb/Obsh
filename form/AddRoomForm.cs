using Obsh.entity;
using Obsh.parser;
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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {

        }


        public Room getRoom()
        {
            return RoomParser.parseRoom(NumberBox.Text, CapacityBox.Text, PriceBox.Text);
        }
    }
}
