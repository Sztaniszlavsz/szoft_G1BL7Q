using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikhet
{
    internal class szamolo : villogogomb
    {
        int szam = 1;
        public szamolo() 
        {
            MouseClick += Szamolo_MouseClick;
            Text = szam.ToString();
        }

        private void Szamolo_MouseClick(object? sender, MouseEventArgs e)
        {
            Text = szam++.ToString();

            if (szam > 6)
            {
                szam = 1;
            }
        }
    }
}
