using System.CodeDom;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace veletlenszeru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();  
            int m�ret = 20;
            for (int sor = 0; sor < 20; sor++)
            
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    Button a = new Button();
                    Controls.Add(a);


                    a.Width = m�ret;
                    a.Height = m�ret;
                    a.Left = m�ret * oszlop;
                    a.Top = m�ret * sor;
                    a.BackColor = Color.FromArgb(random.Next(0,255),0 ,0);
                }
            }
        }
    }
}