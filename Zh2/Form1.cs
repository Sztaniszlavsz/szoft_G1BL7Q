using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace Zh2
{
    public partial class Form1 : Form
    {
        BindingList<FutoVersenyzok> fv = new();
        public  int USAI = 0;
        public  int maxim = int.MaxValue;
        public  string versenyzo;
        public Form1()
        {

            InitializeComponent();
            futoVersenyzokBindingSource.DataSource = fv;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<FutoVersenyzok>();
                foreach (var item in tömb)
                {
                    if (item.Nemzetiseg == "USA")
                    {
                        USAI++;
                    }

                    if (item.EredmenyPerc< maxim)
                    {
                        maxim = item.EredmenyPerc;
                    }
                    if (item.EredmenyPerc == maxim)
                    {
                        versenyzo = item.Nev;
                    }

                    fv.Add(item);
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
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(fv);

                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (futoVersenyzokBindingSource.Current == null) { }

            if (MessageBox.Show("Jóváhagyod a törlést?", "Törlés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futoVersenyzokBindingSource.RemoveCurrent();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            fv.Add(formAdd.UjAdat);

        }

        private void buttonFacts_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Az USA-ból {USAI.ToString()} versenyzõ érkezett, és a legjobb idõt {versenyzo} futotta.");
        }
    }
}