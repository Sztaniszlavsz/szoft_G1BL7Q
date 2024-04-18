using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;

namespace ZH_gyakorlas
{
    public partial class Form1 : Form
    {
        BindingList<VizsgaK�rd�s> k�rd�sek = new();
        public Form1()
        {
            InitializeComponent();
            vizsgaK�rd�sBindingSource.DataSource = k�rd�sek; //!!!!!!!!!!!!!!
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOppen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.csv");

                var csv = new CsvHelper.CsvReader(sr, CultureInfo.InvariantCulture);

                var t�mb = csv.GetRecords<VizsgaK�rd�s>();
                foreach (var item in t�mb)
                {
                    k�rd�sek.Add(item);
                }

                sr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SFD = new SaveFileDialog();

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(SFD.FileName);
                    var csv = new CsvHelper.CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(dataGridView1.SelectedRows);

                    sw.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (vizsgaK�rd�sBindingSource.Current == null) return;
            if (MessageBox.Show("Meger�s�ted a t�rl�st?", "T�rl�s", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vizsgaK�rd�sBindingSource.RemoveCurrent();
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            formAddNew.ShowDialog();
            if(formAddNew.ShowDialog() == DialogResult.OK)
            {

            }
        }

        
    }
}