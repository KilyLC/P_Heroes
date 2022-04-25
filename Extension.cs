using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
      public static class Extension
      {
        const int POURCENTAGE = 20 / 100;
         internal static Heros TraitementHeros(Arme armeChoisi, Tenue tenueChoisi)
         {
            Heros heros = new Heros();
            if (armeChoisi.NbMains == 1)
            {
                heros.Arme1 = armeChoisi;
            }
            else
            {
                heros.Arme1 = armeChoisi;
                heros.Arme2 = armeChoisi;
            }
            heros.Tenue = tenueChoisi;

            //Tenues Stat
            heros.Agilite -= POURCENTAGE * tenueChoisi.Poids;
            heros.NvVie += POURCENTAGE * tenueChoisi.NvDefense;
            heros.VitesseAttaque -= POURCENTAGE * tenueChoisi.Poids;
            //Armes Stat
            heros.Agilite -= POURCENTAGE * armeChoisi.Poids;
            heros.VitesseAttaque -= POURCENTAGE * armeChoisi.Poids;
            
            return heros;
        } 


        
    }
}
