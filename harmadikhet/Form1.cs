using System.CodeDom;

namespace harmadikhet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Button b = new Button();
            Controls.Add(b);

                b.Left  = ClientRectangle.Width / 2 - b.Width/2;
                b.Top = ClientRectangle.Height / 2 - b.Height/2;


            int m�ret = 20;

            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    szamolo a = new szamolo();
                    Controls.Add(a);


                    a.Width = m�ret;
                    a.Height = m�ret;
                    a.Left = m�ret * oszlop;
                    a.Top = m�ret * sor;

                }
            }
        }
    }
}