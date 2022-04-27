using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Compagnie
    {
        const int NB_HEROS_MAX = 3;
        private List<Heros> _heros = new List<Heros>();
        private string _nomCompagnie;
        private List<string> _listeArmes;

        Dictionary<string, dynamic> listeArmes = new Dictionary<string, dynamic>();
        public string NomCompagnie { get => _nomCompagnie; set => _nomCompagnie = value; }
        internal List<Heros> Heros { get => _heros; set => _heros = value; }
        public List<string> ListeArmes { get => _listeArmes; set => _listeArmes = value; }

        public Compagnie(string nom)
        {
            NomCompagnie = nom;
        }

        public List<Heros> AjoutHeros(Heros hero)
        {
            if (Heros.Count < NB_HEROS_MAX)
            {
                Heros.Add(hero);
            }
            return Heros;
        }

        public void InitListeArmes()
        {
            Arme hache = new Arme();
            hache.NvAttaque = 50;
            hache.Durabilite = 50;
            hache.Poids = 55;
            hache.Munitions = 0;
            hache.NbMains = 1;
            hache.Image = Properties.Resources.hache;
            listeArmes["hache"].arme = hache;
            listeArmes["hache"].utilisee = false;

            Arme arc = new Arme();
            arc.NvAttaque = 40;
            arc.Durabilite = 50;
            arc.Poids = 10;
            arc.Munitions = 18;
            arc.NbMains = 2;
            arc.Image = Properties.Resources.arc;
            listeArmes["arc"].arme = arc;
            listeArmes["arc"].utilisee = false;

            Arme epee = new Arme();
            epee.NvAttaque = 50;
            epee.Durabilite = 70;
            epee.Poids = 40;
            epee.Munitions = 0;
            epee.NbMains = 1;
            epee.Image = Properties.Resources.epee;
            listeArmes["epee"].arme = epee;
            listeArmes["epee"].utilisee = false;

            Arme dague = new Arme();
            dague.NvAttaque = 45;
            dague.Durabilite = 60;
            dague.Poids = 30;
            dague.Munitions = 0;
            dague.NbMains = 1;
            dague.Image = Properties.Resources.dague;
            listeArmes["dague"].arme = dague;
            listeArmes["dague"].utilisee = false;

            Arme bouclier = new Arme();
            bouclier.NvAttaque = 10;
            bouclier.Durabilite = 150;
            bouclier.Poids = 70;
            bouclier.Munitions = 0;
            bouclier.NbMains = 1;
            bouclier.Image = Properties.Resources.bouclier;
            listeArmes["bouclier"].arme = bouclier;
            listeArmes["bouclier"].utilisee = false;

            Arme lance = new Arme();
            lance.NvAttaque = 40;
            lance.Durabilite = 40;
            lance.Poids = 25;
            lance.Munitions = 0;
            lance.NbMains = 1;
            lance.Image = Properties.Resources.lance;
            listeArmes["lance"].arme = lance;
            listeArmes["lance"].utilisee = false;
        }

        public void SelectionArme(string nomArme)
        {
            foreach (var arme in listeArmes)
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
