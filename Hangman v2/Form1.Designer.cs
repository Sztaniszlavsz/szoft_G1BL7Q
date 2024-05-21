namespace Hangman_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNewGame = new Button();
            buttonLoad = new Button();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(26, 304);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(75, 23);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "Új játék";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(122, 304);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(126, 23);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Szavak betöltése";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLoad);
            Controls.Add(buttonNewGame);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNewGame;
        private Button buttonLoad;
    }
}
