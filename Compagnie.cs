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
        private int _niveau;
        
        Dictionary<string, DicoValues> listeArmes = new Dictionary<string, DicoValues>();
        public string NomCompagnie { get => _nomCompagnie; set => _nomCompagnie = value; }
        public int Niveau { get => _niveau; set => _niveau = value; }
        public List<Heros> Heros { get => _heros; set => _heros = value; }
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
            hache.NbMains = 2;
            hache.Image = Properties.Resources.hache;
            DicoValues values = new DicoValues(hache, false);
            DicoListeArmes["hache"] = values;

            Arme arc = new Arme();
            arc.NomArme = "arc";
            arc.NvAttaque = 40;
            arc.Durabilite = 50;
            arc.NbMains = 2;
            arc.Image = Properties.Resources.arc;
            values = new DicoValues(arc, false);
            DicoListeArmes["arc"] = values;

            Arme epee = new Arme();
            epee.NomArme = "epee";
            epee.NvAttaque = 50;
            epee.Durabilite = 70;
            epee.NbMains = 1;
            epee.Image = Properties.Resources.epee;
            values = new DicoValues(epee, false);
            DicoListeArmes["epee"] = values;

            Arme dague = new Arme();
            dague.NomArme = "dague";
            dague.NvAttaque = 45;
            dague.Durabilite = 60;
            dague.NbMains = 1;
            dague.Image = Properties.Resources.dague;
            values = new DicoValues(dague, false);
            DicoListeArmes["dague"] = values;

            Arme bouclier = new Arme();
            bouclier.NomArme = "bouclier";
            bouclier.NvAttaque = 10;
            bouclier.Durabilite = 150;
            bouclier.NbMains = 1;
            bouclier.Image = Properties.Resources.bouclier;
            values = new DicoValues(bouclier, false);
            DicoListeArmes["bouclier"] = values;

            Arme lance = new Arme();
            lance.NomArme = "lance";
            lance.NvAttaque = 12;
            lance.Durabilite = 40;
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
