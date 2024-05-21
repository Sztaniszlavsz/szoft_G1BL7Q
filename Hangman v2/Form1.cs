using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hangman_v2
{
    public partial class Form1 : Form
    {
        private List<string> words;
        private string currentWord;
        private string maskedWord;
        private int hiba;
        private Label wordLabel;
        private Label hibaLabel;
        private FlowLayoutPanel keyboardPanel;
        private PictureBox pictureBox;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();

        }

        public void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Szavak betöltése"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    words = content.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(w => w.Trim().ToUpper()).ToList();
                    MessageBox.Show("Szavak sikeresen betöltve!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a fájl beolvasása közben: {ex.Message}");
                }
            }
        }

        public void buttonNewGame_Click(object sender, EventArgs e)
        {
            if (words == null || words.Count == 0)
            {
                MessageBox.Show("Először tölts be egy szavak listáját!");
                return;
            }

            hiba = 0;
            hibaLabel.Text = "Hibák: 0";
            currentWord = words[random.Next(words.Count)];
            maskedWord = new string('_', currentWord.Length);
            wordLabel.Text = maskedWord;
            InitializeKeyboard();
            Rajzolas(0);
        }

        public void InitializeGame()
        {
            wordLabel = new Label
            {
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Arial", 24)
            };
            this.Controls.Add(wordLabel);

            hibaLabel = new Label
            {
                Location = new Point(10, 50),
                AutoSize = true
            };
            this.Controls.Add(hibaLabel);

            keyboardPanel = new FlowLayoutPanel
            {
                Location = new Point(10, 100),
                Size = new Size(260, 200)
            };
            this.Controls.Add(keyboardPanel);

            pictureBox = new PictureBox
            {
                Location = new Point(300, 10),
                Size = new Size(300, 400)
            };
            this.Controls.Add(pictureBox);
        }

        private void LoadWordsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Szavak betöltése"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    words = content.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(w => w.Trim().ToUpper()).ToList();
                    MessageBox.Show("Szavak sikeresen betöltve!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt a fájl beolvasása közben: {ex.Message}");
                }
            }
        }

        private void InitializeKeyboard()
        {
            keyboardPanel.Controls.Clear();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                Button button = new Button
                {
                    Text = c.ToString(),
                    Width = 30,
                    Height = 30,
                    Tag = c
                };
                button.Click += LetterButton_Click;
                keyboardPanel.Controls.Add(button);
            }
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            char guessedLetter = (char)button.Tag;
            button.Enabled = false;

            if (currentWord.Contains(guessedLetter))
            {
                char[] maskedChars = maskedWord.ToCharArray();
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (currentWord[i] == guessedLetter)
                    {
                        maskedChars[i] = guessedLetter;
                    }
                }
                maskedWord = new string(maskedChars);
                wordLabel.Text = maskedWord;

                if (!maskedWord.Contains('_'))
                {
                    MessageBox.Show("Gratulálok! Kitaláltad a szót!");
                }
            }
            else
            {
                hiba++;
                hibaLabel.Text = $"Hibák: {hiba}";
                Rajzolas(hiba);
                if (hiba > 5)
                {
                    MessageBox.Show($"Vesztettél! A helyes szó: {currentWord}");
                    foreach (Control control in keyboardPanel.Controls)
                    {
                        if (control is Button btn)
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }

        private void Rajzolas(int szint)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(Color.Black, 2);

                // Akasztófa talp rajzolása
                g.DrawLine(pen, new Point(10, 380), new Point(190, 380));
                if (szint == 0) goto DrawEnd;

                // Akasztófa oszlop rajzolása
                g.DrawLine(pen, new Point(100, 20), new Point(100, 380));
                if (szint == 1) goto DrawEnd;

                // Akasztófa vízszintes gerenda rajzolása
                g.DrawLine(pen, new Point(100, 20), new Point(180, 20));
                if (szint == 2) goto DrawEnd;

                // Kötél rajzolása
                g.DrawLine(pen, new Point(180, 20), new Point(180, 50));
                if (szint == 3) goto DrawEnd;

                // Fej rajzolása
                g.DrawEllipse(pen, new Rectangle(160, 50, 40, 40));
                if (szint == 4) goto DrawEnd;

                // Törzs rajzolása
                g.DrawLine(pen, new Point(180, 90), new Point(180, 200));
                if (szint == 5) goto DrawEnd;

                // Karok rajzolása
                g.DrawLine(pen, new Point(180, 120), new Point(150, 150));
                g.DrawLine(pen, new Point(180, 120), new Point(210, 150));
                g.DrawLine(pen, new Point(180, 200), new Point(150, 250));
                g.DrawLine(pen, new Point(180, 200), new Point(210, 250));

            DrawEnd:
                pictureBox.Image = bmp;
            }
        }

    }
}
