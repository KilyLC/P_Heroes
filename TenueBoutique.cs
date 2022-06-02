using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace P_Heroes
{
    public class TenueBoutique : ObjetBoutique
    {
        // Champs
        private int _protectionMin;
        private int _protectionMax;
        private int _poids;

        public int ProtectionMin { get => _protectionMin; }
        public int ProtectionMax { get => _protectionMax; }
        public int Poids { get => _poids; }

        // Redéfinition des stats
        public override string StatistiquesEnTexte()
        {
            string stats_str = base.StatistiquesEnTexte();

            return stats_str + "\nProtection : " + _protectionMin + " - " + ProtectionMax;
        }

        public TenueBoutique(string nom, int prix, Image miniature, string description, int niveau, RareteObjet rarete, int durabilite, int poids)
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
            // Calculs de la protection
            this._protectionMax = (int)Math.Ceiling(niveau * 10 * multiplicateur_rarete);
            this._protectionMin = Math.Max(this.ProtectionMax - 10, 0); // Pour l'instant

            this._poids = poids;
        }
    }
}
