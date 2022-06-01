using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace P_Heroes.Model
{
    // Rareté d'un objet
    public enum RareteObjet
    {
        Commun,
        PeuCommun,
        Rare,
        TresRare,
        Legendaire
    }

    public abstract class ObjetBoutique
    {
        // Champs
        private string _nom;
        private int _prix;
        private Image _miniature;
        private string _description;
        private RareteObjet _rarete;
        private int _niveau;            // min 1 max 50
        private int _durabilite = 100;
        private int _pasUtilisation = 1;        // Cout de durabilite par utilisation

        // Constantes
        const int NIVEAU_MAX = 50;
        const int NIVEAU_MIN = 1;

        const int DURABILITE_MAX = 100;
        const int DURABILITE_MIN = 1;

        // Propriétés
        public string Nom { get => _nom; }
        public int Prix { get => _prix; }
        public Image Miniature { get => _miniature; }
        public string Description { get => _description; }
        internal RareteObjet Rarete { get => _rarete; }
        public int Niveau { get => _niveau; }               // 1 - 50
        public int Durabilite { get => _durabilite; }
        public int PasUtilisation { get => _pasUtilisation; }

        public ObjetBoutique(string nom, int prix, Image miniature, string description, int niveau, RareteObjet rarete, int durabilite)
        {
            // Vérifie bien que les propriétés données soient bien valides
            if (niveau > NIVEAU_MAX || niveau < NIVEAU_MIN)
                throw new Exception("Niveau d'objet non valide");

            if (prix < 0)
                throw new Exception("Prix non valide");

            if (durabilite > DURABILITE_MAX || durabilite < DURABILITE_MIN)
                throw new Exception("Durabilité d'objet non valide");

            this._nom = nom;
            this._prix = prix;
            this._miniature = miniature;
            this._description = description;

            this._niveau = niveau;

            this._rarete = rarete;
            
            this._durabilite = durabilite;
        }

        // Texte selon rareté
        public virtual string StatistiquesEnTexte()
        {
            string stats_str = "Rareté : ";
            switch (this.Rarete)
            {
                case RareteObjet.Commun:
                    stats_str += "commun";
                    break;
                case RareteObjet.PeuCommun:
                    stats_str += "peu commun";
                    break;
                case RareteObjet.Rare:
                    stats_str += "rare";
                    break;
                case RareteObjet.TresRare:
                    stats_str += "très rare";
                    break;
                case RareteObjet.Legendaire:
                    stats_str += "légendaire";
                    break;
            }
            stats_str += "\nNiveau : " + Niveau;
            stats_str += "\nDurabilité : " + Durabilite;
            return stats_str;
        }

        public void DefinirPasUtilisation(int pas)
        {
            _pasUtilisation = pas;
        }

        public virtual int CalculPrix()
        {
            return Convert.ToInt32(Durabilite / 100 * _prix);
        }

        public virtual int CalculPrixVente()
        {
            return Convert.ToInt32(Durabilite / 100 * _prix * 0.8);
        }

        // Permet de savoir si l'objet a assez de durabilité pour pouvoir attaquer
        public virtual bool Utiliser()
        {
            if (_durabilite <= 0)
                return false;

            _durabilite = _durabilite - _pasUtilisation;
            return true;
        }
    }
}
