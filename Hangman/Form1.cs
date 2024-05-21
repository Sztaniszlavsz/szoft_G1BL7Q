using System;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Word word;
        public int hiba = 0;
        Label label1;
        Label label2;

        private void Form1_Load(object sender, EventArgs e)
        {
            word = new Word("Papika");
            hiba = 0;

            label1 = new Label
            {
                Text = word.WordMask,
                Location = new System.Drawing.Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(label1);

            label2 = new Label
            {
                Text = "Hibák: 0",
                Location = new System.Drawing.Point(10, 40),
                AutoSize = true
            };
            this.Controls.Add(label2);

            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (word.Guess(e.KeyChar))
            {
                label1.Text = word.WordMask;
                if (!word.WordMask.Contains('_'))
                {
                    MessageBox.Show("Gratulálok! Kitaláltad a szót!");
                }
            }
            else
            {
                hiba++;
                label2.Text = $"Hibák: {hiba}";
                if (hiba > 5)
                {
                    MessageBox.Show("Vesztettél! A helyes szó: " + word.OriginalWord);
                }
            }
        }
    }
}
