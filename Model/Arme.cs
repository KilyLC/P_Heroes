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
            return "Dégâts : "+_degatsMin+" - "+_degatsMax;
        }

        public Arme(string nom, uint prix, Image miniature, string description, int niveau, int durabilite, int degatsMin, int degatsMax)
            : base(nom, prix, miniature, description, niveau, durabilite)
        {
            if (degatsMin < 0 || degatsMax < 0 || degatsMin > degatsMax)
                throw new Exception("Degats non valides");

            this._degatsMin = degatsMin;
            this._degatsMax = degatsMax;
        }

    }
}
