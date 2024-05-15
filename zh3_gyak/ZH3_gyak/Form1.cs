using ZH3_gyak.Models;

namespace ZH3_gyak
{
    public partial class Form1 : Form
    {
        StudiesContext context = new StudiesContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                Room room = new Room();
                room.Name = form2.textBox1.Text;

                context.Rooms.Add(room);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl4 = new UserControl4();
            panel1.Controls.Add(userControl4);
            userControl4.Dock = DockStyle.Fill;
        }
    }
}