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
        private List<Heros> _herosBase = new List<Heros>();
        private string _nomCompagnie;
        private int _niveau;
        private int _po;
        private int _xp;
        private int _nbXpPalierNiveau;
        private int _nivCampagne;
        
        Dictionary<string, DicoValues> listeArmes = new Dictionary<string, DicoValues>();
        Dictionary<string, DicoValues> listeTenues = new Dictionary<string, DicoValues>();
        public string NomCompagnie { get => _nomCompagnie; set => _nomCompagnie = value; }
        public int Niveau { get => _niveau; set => _niveau = value; }
        public List<Heros> Heros { get => _heros; set => _heros = value; }
        public Dictionary<string, DicoValues> DicoListeArmes { get => listeArmes; set => listeArmes = value; }
        public Dictionary<string, DicoValues> DicoListeTenues { get => listeTenues; set => listeTenues = value; }
        public List<Heros> HerosBase { get => _herosBase; set => _herosBase = value; }
        public Inventaire Inventaire { get; set; }
        public int Po { get => _po; set => _po = value; }
        public int Xp { get => _xp; set => _xp = value; }
        public int NbXpPalierNiveau { get => _nbXpPalierNiveau; set => _nbXpPalierNiveau = value; }
        public int NivCampagne { get => _nivCampagne; set => _nivCampagne = value; }

        public Compagnie()
        {
            this.NbXpPalierNiveau = 500;
            this.Po = 0;
            this.Niveau = 1;
            this.NivCampagne = 1;
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
        /// Maj selon arme séléctionné
        /// </summary>
        public void SelectionArme(string nomArme)
        {
            foreach (var arme in DicoListeArmes)
            {
                if (arme.Key == nomArme)
                {
                    arme.Value.utiliseeArme = true;
                }
                else
                {
                    arme.Value.utiliseeArme = false;
                }
            }
        }
    }
}
