using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace P_Heroes.Model
{
    class Arme : Objet
    {
        private int _degatsMin;
        private int _degatsMax;

        public override string statistiquesEnTexte()
        {
            string stats_str = base.statistiquesEnTexte();
            return stats_str + "\nDégâts : " + _degatsMin + " - " + _degatsMax;
        }

        public Arme(string nom, int prix, Image miniature, string description, int niveau, RareteObjet rarete, int durabilite)
            : base(nom, prix, miniature, description, niveau, rarete, durabilite)
        {
            double multiplicateur_rarete = 0;
            switch (rarete)
            {
                case RareteObjet.Commun:
                    multiplicateur_rarete = 0.2;
                    break;
                case RareteObjet.PeuCommun:
                    multiplicateur_rarete = 0.4;
                    break;
                case RareteObjet.Rare:
                    multiplicateur_rarete = 0.6;
                    break;
                case RareteObjet.TresRare:
                    multiplicateur_rarete = 0.8;
                    break;
                case RareteObjet.Legendaire:
                    multiplicateur_rarete = 1.0;
                    break;
            }
            
            this._degatsMax = (int)Math.Ceiling(niveau * 10 * multiplicateur_rarete);
            this._degatsMin = Math.Max(this._degatsMax - 10, 0); // Pour l'instant
        }

        public void DefinirDegats(int min, int max)
        {
            this._degatsMin = min;
            this._degatsMax = max;
        }
    }
}
