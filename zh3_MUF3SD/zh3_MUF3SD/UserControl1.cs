using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_MUF3SD.Models;

namespace zh3_MUF3SD
{
    public partial class UserControl1 : UserControl
    {
        SeCocktailsContext context = new SeCocktailsContext();

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var instructors = from l in context.Materials
                              select new
                              {

                                  Név = l.Name,
                                  Ár = l.Price,
                                  Tipus = l.TypeFkNavigation.Name,
                                  Unit = l.UnitFkNavigation.Name
                              };
            dataGridView1.DataSource = instructors.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog SFD = new SaveFileDialog();
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(SFD.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(context.Materials);
                    sw.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
