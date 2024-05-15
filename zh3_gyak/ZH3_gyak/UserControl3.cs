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
using CsvHelper;
using System.Globalization;

namespace ZH3_gyak
{
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        public void UserControl3_Load(object sender, EventArgs e)
        {
            var instructors = from l in context.Instructors
                              select new
                              {
                                  ID = l.InstructorSk,
                                  Sal = l.Salutation,
                                  Név = l.Name,
                                  Státusz = l.StatusFkNavigation.Name,
                                  Állás = l.EmployementFkNavigation.Name
                              };
            dataGridView1.DataSource = instructors.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SaveFileDialog SFD = new SaveFileDialog();
                if (SFD.ShowDialog() == DialogResult.OK) { 
                    StreamWriter sw = new StreamWriter(SFD.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(context.Instructors);
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
