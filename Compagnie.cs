using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Compagnie
    {
        const int NB_HEROS_MAX = 3;
        private List<Heros> _heros = new List<Heros>();
        private string _nomCompagnie;

        public string NomCompagnie { get => _nomCompagnie; set => _nomCompagnie = value; }
        internal List<Heros> Heros { get => _heros; set => _heros = value; }

        public Compagnie(string nom)
        {
            NomCompagnie = nom;
        }

        public List<Heros> ajoutHeros(Heros hero)
        {
            if (Heros.Count < NB_HEROS_MAX)
            {
                Heros.Add(hero);
            }
            return Heros;
        }
    }
}
