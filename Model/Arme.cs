using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes.Model
{
    class Arme : Objet
    {
        private int _degatsMin;
        private int _degatsMax;

        public override string statistiqueEnText()
        {
            return "Dégâts : "+_degatsMin+" - "+_degatsMax;
        }
    }
}
