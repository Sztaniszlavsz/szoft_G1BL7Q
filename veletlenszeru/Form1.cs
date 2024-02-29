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
            Random rnd = new Random();
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    int méret= rnd.Next();

                    Button a = new Button();
                    Controls.Add(a);


                    a.Width = méret;
                    a.Height = méret;
                    a.Left = méret * oszlop;
                    a.Top = méret * sor;
                    a.BackColor = Color.FromArgb(random.Next(0,255),0 ,0);
                }
            }
        }
    }
}