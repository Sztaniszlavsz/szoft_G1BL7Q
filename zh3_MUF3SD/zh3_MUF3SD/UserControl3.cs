using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_MUF3SD.Models;

namespace zh3_MUF3SD
{
    public partial class UserControl3 : UserControl
    {
        SeCocktailsContext context = new SeCocktailsContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                MaterialType nev = new MaterialType();
                nev.Name = form2.textBox1.Text;
                nev.MaterialTypeId = (byte)(context.MaterialTypes.Max(x => x.MaterialTypeId) + 1);

                context.MaterialTypes.Add(nev);
                

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                dataGridView1.DataSource = (from x in context.MaterialTypes select x).ToList();
            }
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.MaterialTypes.ToList();
        }
    }
}
