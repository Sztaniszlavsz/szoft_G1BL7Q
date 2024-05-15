using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH3_gyak.Models;

namespace ZH3_gyak
{
    public partial class UserControl4 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = context.Rooms.ToList();
            var szam = dataGridView1.RowCount;
            label1.Text = ($"Sorok száma: {szam}");
        }


    }
}
