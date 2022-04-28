using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public class DicoValues
    {
        public DicoValues(Arme arme, bool utilisee)
        {
            this.arme = arme;
            this.utilisee = utilisee;
        }

        public Arme arme { get; set; }
        public bool utilisee { get; set; }
    }
}
