using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public class Inventaire
    {
        private List<Arme> _armes;
        private List<Tenue> _tenues;
        public List<Arme> Armes { get => _armes; set => _armes = value; }
        public List<Tenue> Tenues { get => _tenues; set => _tenues = value; }

        public void AjoutArme(Arme arme)
        {
            this.Armes.Add(arme);
        }

        public void AjoutTenue(Tenue tenue)
        {
            this.Tenues.Add(tenue);
        }
    }
}
