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
    public partial class UserControl1 : UserControl
    {

        StudiesContext context = new StudiesContext();
       
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            var ilist = (from i in context.Instructors select i).ToList();
            listBox1.DataSource = ilist;
            listBox1.DisplayMember = "Name";

            FillDataSource();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from i in context.Instructors where i.Name.StartsWith(textBox1.Text) select i).ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor selectedInstructor = listBox1.SelectedItem as Instructor;


            var lessons = from l in context.Lessons
                          where l.InstructorFk == selectedInstructor.InstructorSk
                          select new
                          {
                              Kurzus = l.CourseFkNavigation.Name,
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name
                          };
            dataGridView1.DataSource = lessons.ToList();
        }
    }
}
