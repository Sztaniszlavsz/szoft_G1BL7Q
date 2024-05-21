using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zh3_MUF3SD.Models;

namespace zh3_MUF3SD
{
    public partial class UserControl2 : UserControl
    {

        SeCocktailsContext context = new SeCocktailsContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Cocktail cocktail = listBox1.SelectedItem as Cocktail;

            dataGridView1.DataSource = (from l in context.Recipes
                                        where l.CocktailFk == cocktail.CocktailSk
                                        select new
                                        {
                                            Koktel = l.CocktailFkNavigation.Name,
                                            alapanyag = l.MaterialFkNavigation.Name,
                                            mennyiseg = l.Quantity,
                                            recept = l.RecipeSk
                                        }).ToList();
        }

        public void FillDataSource()
        {
            listBox1.DataSource = (from c in context.Cocktails where c.Name.Contains(textBox1.Text) select c).ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }
    }
}
