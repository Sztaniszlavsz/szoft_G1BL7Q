namespace Zh1_gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                LoveButton lb = new LoveButton();
                lb.Top = (lb.Height + 1) * i;
                lb.Left = ClientRectangle.Width / 2;

                Controls.Add(lb);

            }

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sorokSz�ma = int.Parse(textBox1.Text);

            Random rnd = new Random();
            List<R�csEgySora> sorok = new List<R�csEgySora>();

            for (int i = 0; i < sorokSz�ma; i++)
            {

                int v�letlen = rnd.Next(1, 7);
                R�csEgySora r�csEgySora = new R�csEgySora();

                r�csEgySora.Sorsz�m = i;
                r�csEgySora.V�letlenSz�m = v�letlen;
                r�csEgySora.Fibo = Fibonacci(i);

                sorok.Add(r�csEgySora);
            }

            dataGridView1.DataSource = sorok;
        }
    }
}