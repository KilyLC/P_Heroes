using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes.Model
{
    public class InventaireBoutique
    {
        private List<ObjetBoutique> _objets;
        private int _argent;
        public int Argent { get => _argent; }
        public List<ObjetBoutique> Objets { get => _objets; set => _objets = value; }

        public InventaireBoutique()
        {
            this._objets = new List<ObjetBoutique>();
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
