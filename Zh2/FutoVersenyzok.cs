using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//VersenyzoID,Nev,Nemzetiseg,EredmenyPerc,Kategoria
namespace Zh2
{
    public class FutoVersenyzok
    {
        public int VersenyzoID { get; set; }
        public string Nev { get; set; }

        public string Nemzetiseg { get; set; }

        public int EredmenyPerc { get; set; }

        public string Kategoria { get; set; }
    }
}
