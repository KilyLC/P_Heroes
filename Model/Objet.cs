using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace P_Heroes.Model
{
    public enum RareteObjet
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
        private uint _prix;
        private Image _miniature;
        private string _description;
        private RareteObjet _rarete;
        private int _niveau;            // min 1 max 50
        private int _durabilite = 100;
        private int _pasUtilisation = 1;        // Cout de durabilite par utilisation

        const int NIVEAU_MAX = 10;
        const int NIVEAU_MIN = 1;

        const int DURABILITE_MAX = 100;
        const int DURABILITE_MIN = 1;

        public string Nom { get => _nom; }
        public uint Prix { get => _prix; }
        public Image Miniature { get => _miniature; }
        public string Description { get => _description; }
        internal RareteObjet Rarete { get => _rarete; }
        public int Niveau { get => _niveau; }               // 1 - 10
        public int Durabilite { get => _durabilite; }

        public Objet(string nom, uint prix, Image miniature, string description, int niveau, int durabilite)
        {
            this._nom = nom;
            this._prix = prix;
            this._miniature = miniature;
            this._description = description;

            if (niveau > NIVEAU_MAX || niveau < NIVEAU_MIN)
                throw new Exception("Niveau d'objet non valide");

            this._niveau = niveau;

            // Rareté
            if (niveau <= 2) this._rarete = RareteObjet.Commun;
            else if (niveau <= 4) this._rarete = RareteObjet.PeuCommun;
            else if (niveau <= 6) this._rarete = RareteObjet.Rare;
            else if (niveau <= 8) this._rarete = RareteObjet.TresRare;
            else if (niveau <= 10) this._rarete = RareteObjet.Legendaire;

            if (durabilite > DURABILITE_MAX || durabilite < DURABILITE_MIN)
                throw new Exception("Durabilité d'objet non valide");

            this._durabilite = durabilite;
        }

        public abstract string statistiquesEnTexte();

        public virtual int calculPrix()
        {
            return (int)Math.Ceiling((decimal)((Durabilite / 100) * _prix));
        }

        public virtual void utiliser()
        {
            _durabilite = _durabilite - _pasUtilisation;
        }
    }
}
