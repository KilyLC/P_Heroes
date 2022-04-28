using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Heroes
{
    public class Arme
    {
        public string NomArme { get; set; }
        public int NvAttaque { get; set; }
        public int Durabilite { get; set; }
        public int Poids { get; set; }
        public int Munitions{ get; set; }
        public int NbMains { get; set; }
        public Image Image { get; set; }

        public Arme()
        {
        }
        
    }
}
