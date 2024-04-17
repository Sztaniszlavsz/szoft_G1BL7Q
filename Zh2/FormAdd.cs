using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zh2
{
    public partial class FormAdd : Form
    {
        public FutoVersenyzok UjAdat { get; set; }
        public FormAdd()
        {
            InitializeComponent();
            UjAdat = new FutoVersenyzok();
            bindingSource1.DataSource = UjAdat;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
