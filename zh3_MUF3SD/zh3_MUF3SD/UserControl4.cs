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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zh3_MUF3SD
{
    public partial class UserControl4 : UserControl
    {
        SeCocktailsContext context = new SeCocktailsContext();
        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {



            var atlag = context.Cocktails.Average(x => x.Price);


            var olcsobbKoktelok = from x in context.Cocktails
                                  where x.Price < atlag
                                  select x;


            StringBuilder result = new StringBuilder();

            foreach (var koktel in olcsobbKoktelok)
            {
                result.AppendLine($"Átlag alattiak: {koktel.Name}");
            }

            label1.Text = result.ToString();


            var darab = context.Recipes.Count();


            label2.Text = atlag.ToString();

            label3.Text = darab.ToString();
        }
    }
}
