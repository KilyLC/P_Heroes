using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    /// <summary>
    /// Compagnie du joueur
    /// </summary>
    public static class CompagnieStocker
    {
        //compagnie sélectionné
        public static Compagnie compagnieActuelle;
        //Toutes les compagnies
        public static List<Compagnie> compagniesJoueur = new List<Compagnie>();
        //Nombre de compagnie maximum
        public const int NB_COMPAGNIE_MAX = 6;

    }
}
