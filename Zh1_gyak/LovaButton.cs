using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh1_gyak
{
    internal class LoveButton : Label
    {
        int szám = 1;
        public LoveButton()
        {
            BackColor = Color.White;
            Click += LoveButton_Click;
            AutoSize = true;
            Text = "\u2764";


        }

        private void LoveButton_Click(object? sender, EventArgs e)
        {
            szám++;
            if (szám == 4) szám = 1;
            //this.Text = $"A szám {szám}";
            Text = string.Empty;
            for (int i = 0; i < szám; i++)
            {
                Text += "\u2764";
            }

            
        }

    }
}
