using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes.Model
{
    public class Inventaire
    {
        private List<Objet> _objets;
        private int _argent;
        public int Argent { get => _argent; }
        public List<Objet> Objets { get => _objets; set => _objets = value; }

        public Inventaire()
        {
            this._objets = new List<Objet>();
        }
        
        private void AjoutArgent(int montant)
        {
            _argent += montant;
        }

        private void RetraitArgent(int montant)
        {
            _argent = Math.Max(_argent - montant, 0);
        }
    }
}
