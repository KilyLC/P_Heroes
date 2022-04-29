/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class compagnie
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public class Compagnie
    {
        const int NB_HEROS_MAX = 3;
        private List<Heros> _heros = new List<Heros>();
        private string _nomCompagnie;
        private List<string> _listeArmes = new List<string>();

        Dictionary<string, DicoValues> listeArmes = new Dictionary<string, DicoValues>();
        public string NomCompagnie { get => _nomCompagnie; set => _nomCompagnie = value; }
        internal List<Heros> Heros { get => _heros; set => _heros = value; }
        public List<string> ListeArmes { get => _listeArmes; set => _listeArmes = value; }
        public Dictionary<string, DicoValues> DicoListeArmes { get => listeArmes; set => listeArmes = value; }

        public Compagnie()
        {
            
        }
        /// <summary>
        /// Maj du nom de la compagnie
        /// </summary>
        public void majNom(string nom)
        {
            NomCompagnie = nom;
        }
        /// <summary>
        /// Ajout d'un héro à la compagnie
        /// </summary>
        public List<Heros> AjoutHeros(Heros hero)
        {
            if (Heros.Count < NB_HEROS_MAX)
            {
                Heros.Add(hero);
            }
            return Heros;
        }
        /// <summary>
        /// Init des armes
        /// </summary>
        public void InitListeArmes()
        {

            ListeArmes.Add("hache");
            ListeArmes.Add("bouclier");
            ListeArmes.Add("dague");
            ListeArmes.Add("epee");
            ListeArmes.Add("lance");
            ListeArmes.Add("arc");


            Arme hache = new Arme();
            hache.NomArme = "hache";
            hache.NvAttaque = 50;
            hache.Durabilite = 50;
            hache.Poids = 55;
            hache.Munitions = 0;
            hache.NbMains = 2;
            hache.Image = Properties.Resources.hache;
            DicoValues values = new DicoValues(hache, false);
            DicoListeArmes["hache"] = values;

            Arme arc = new Arme();
            arc.NomArme = "arc";
            arc.NvAttaque = 40;
            arc.Durabilite = 50;
            arc.Poids = 10;
            arc.Munitions = 18;
            arc.NbMains = 2;
            arc.Image = Properties.Resources.arc;
            values = new DicoValues(arc, false);
            DicoListeArmes["arc"] = values;

            Arme epee = new Arme();
            epee.NomArme = "epee";
            epee.NvAttaque = 50;
            epee.Durabilite = 70;
            epee.Poids = 40;
            epee.Munitions = 0;
            epee.NbMains = 1;
            epee.Image = Properties.Resources.epee;
            values = new DicoValues(epee, false);
            DicoListeArmes["epee"] = values;

            Arme dague = new Arme();
            dague.NomArme = "dague";
            dague.NvAttaque = 45;
            dague.Durabilite = 60;
            dague.Poids = 30;
            dague.Munitions = 0;
            dague.NbMains = 1;
            dague.Image = Properties.Resources.dague;
            values = new DicoValues(dague, false);
            DicoListeArmes["dague"] = values;

            Arme bouclier = new Arme();
            bouclier.NomArme = "bouclier";
            bouclier.NvAttaque = 10;
            bouclier.Durabilite = 150;
            bouclier.Poids = 70;
            bouclier.Munitions = 0;
            bouclier.NbMains = 1;
            bouclier.Image = Properties.Resources.bouclier;
            values = new DicoValues(bouclier, false);
            DicoListeArmes["bouclier"] = values;

            Arme lance = new Arme();
            lance.NomArme = "lance";
            lance.NvAttaque = 40;
            lance.Durabilite = 40;
            lance.Poids = 25;
            lance.Munitions = 0;
            lance.NbMains = 1;
            lance.Image = Properties.Resources.lance;
            values = new DicoValues(lance, false);
            DicoListeArmes["lance"] = values;
        }
        /// <summary>
        /// Maj selon arme séléctionné
        /// </summary>
        public void SelectionArme(string nomArme)
        {
            DicoListeArmes["lance"].utilisee = true;
            foreach (var arme in DicoListeArmes)
            {
                if (arme.Key == nomArme)
                {
                    arme.Value.utilisee = true;
                }
                else
                {
                    arme.Value.utilisee = false;
                }
            }
        }
    }
}
