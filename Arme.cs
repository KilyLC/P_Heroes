using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Arme
    {
        public string NomArme { get; set; }
        public int NvAttaque { get; set; }
        public int Durabilite { get; set; }
        public List<Arme> ListeArmes { get; set; }
        public int Poids { get; set; }
        public int Munitions{ get; set; }
        public int NbMains { get; set; }


        public Arme()
        {
         
           
        }
        public List<Arme> InitListeArmes(string nomArme)
        {
            Arme arme = new Arme();
            arme.NomArme = nomArme;

            if (nomArme == "hache")
            {
                arme.NvAttaque = 50;
                arme.Durabilite = 50;
                arme.Poids = 55;
                arme.Munitions = 0;
                arme.NbMains = 1;
            }
            else if (nomArme == "arc")
            {
                arme.NvAttaque = 40;
                arme.Durabilite = 50;
                arme.Poids = 10;
                arme.Munitions = 18;
                arme.NbMains = 2;
            }
            else if (nomArme == "epee")
            {
                arme.NvAttaque = 50;
                arme.Durabilite = 70;
                arme.Poids = 40;
                arme.Munitions = 0;
                arme.NbMains = 1;
            }
            else if (nomArme == "dague")
            {
                arme.NvAttaque = 45;
                arme.Durabilite = 60;
                arme.Poids = 30;
                arme.Munitions = 0;
                arme.NbMains = 1;
            }
            else if (nomArme == "bouclier")
            {
                arme.NvAttaque = 10;
                arme.Durabilite = 150;
                arme.Poids = 70;
                arme.Munitions = 0;
                arme.NbMains = 1;
            }
            else if (nomArme == "lance")
            {
                arme.NvAttaque = 40;
                arme.Durabilite = 40;
                arme.Poids = 25;
                arme.Munitions = 0;
                arme.NbMains = 1;
            }
            arme.ListeArmes.Add(arme);
            return ListeArmes;
        }
        public List<Arme> TraitementListeArmes(string nomArme)
        {
            foreach (Arme arme in ListeArmes)
            {
                if (nomArme == arme.NomArme)
                {
                    ListeArmes.Remove(arme);
                }
            }

            return ListeArmes;
        }
        
    }
}
