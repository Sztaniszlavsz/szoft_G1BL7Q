namespace ZH_gyakorlas
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
            components = new System.ComponentModel.Container();
            buttonOppen = new Button();
            dataGridView1 = new DataGridView();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vizsgaKérdésBindingSource = new BindingSource(components);
            buttonSave = new Button();
            buttonDelete = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOppen
            // 
            buttonOppen.Location = new Point(713, 88);
            buttonOppen.Name = "buttonOppen";
            buttonOppen.Size = new Size(75, 23);
            buttonOppen.TabIndex = 0;
            buttonOppen.Text = "Megnyitás";
            buttonOppen.UseVisualStyleBackColor = true;
            buttonOppen.Click += buttonOppen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vizsgaKérdésBindingSource;
            dataGridView1.Location = new Point(12, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 1;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.Visible = false;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.Visible = false;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.Visible = false;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.Visible = false;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.Visible = false;
            // 
            // vizsgaKérdésBindingSource
            // 
            vizsgaKérdésBindingSource.DataSource = typeof(VizsgaKérdés);
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 117);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(713, 146);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V1", true));
            textBox1.Location = new Point(12, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V2", true));
            textBox2.Location = new Point(12, 74);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V3", true));
            textBox3.Location = new Point(12, 118);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "HelyesValasz", true));
            textBox4.Location = new Point(12, 161);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 23);
            textBox4.TabIndex = 7;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(713, 59);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(75, 23);
            buttonAddNew.TabIndex = 8;
            buttonAddNew.Text = "Új";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddNew);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Controls.Add(buttonOppen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOppen;
        private DataGridView dataGridView1;
        private Button buttonSave;
        private BindingSource vizsgaKérdésBindingSource;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonAddNew;
    }
}