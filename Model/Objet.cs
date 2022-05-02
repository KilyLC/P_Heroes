using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace P_Heroes.Model
{
    enum RareteObjet
    {
        Commun,
        PeuCommun,
        Rare,
        TresRare,
        Legendaire
    }

    public abstract class Objet
    {
        private string _nom;
        private int _prix;
        private Image _miniature;
        private string _description;
        private RareteObjet _rarete;
        private int _niveau;            // min 1 max 50
        private int _durabilite = 100;
        private int _pasUtilisation = 1;        // Cout de durabilite par utilisation

        public string Nom { get => _nom; }
        public Image Miniature { get => _miniature; }
        public string Description { get => _description; }
        internal RareteObjet Rarete { get => _rarete; }
        public int Niveau { get => _niveau; }

        public virtual string statistiqueEnText() {
            return "";
        }

        public virtual int calculPrix()
        {
            return (int)Math.Round((decimal)(_prix / 100 * _durabilite));
        }

        public virtual void utiliser()
        {
            _durabilite = _durabilite - _pasUtilisation;
        }
    }
}
