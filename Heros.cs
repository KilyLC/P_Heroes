/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Heros
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Heroes
{
    public class Heros
    {
        private string _nomHeros;
        private Tenue _tenue;
        private int _nvVie;
        private int _attaque;
        private int _agilite;
        private string _capaciteSpecial;
        private bool _defenseSpeciale;
        private bool _defense;
        private int _niveau;
        private Arme _arme1;
        private Arme _arme2;
        private Compagnie _compagnie;
        private Image imageHero;

        public string NomHeros { get => _nomHeros; set => _nomHeros = value; }
        public int NvVie { get => _nvVie; set => _nvVie = value; }
        public int Agilite { get => _agilite; set => _agilite = value; }
        public int Attaque { get => _attaque; set => _attaque = value; }
        public int Niveau { get => _niveau; set => _niveau = value; }
        public bool Vivant { get; set; }
        public Image ImageHero { get => imageHero; set => imageHero = value; }
        public Tenue Tenue { get => _tenue; set => _tenue = value; }
        public Arme Arme1 { get => _arme1; set => _arme1 = value; }
        public Arme Arme2 { get => _arme2; set => _arme2 = value; }
        public Compagnie Compagnie { get => _compagnie; set => _compagnie = value; }
        public string CapaciteSpecial { get => _capaciteSpecial; set => _capaciteSpecial = value; }
        public bool DefenseSpeciale { get => _defenseSpeciale; set => _defenseSpeciale = value; }
        public bool Defense { get => _defense; set => _defense = value; }

        /// <summary>
        /// Créer un héros
        /// </summary>
        public void CreeHero(int nvVie, int agilite, int attaque, string nomHero, Image image, bool vivant, Compagnie compagnie, string capaciteSpeciale)
        {
            Agilite = agilite;
            Attaque = attaque;
            NvVie = nvVie;
            NomHeros = nomHero;
            Vivant = vivant;
            ImageHero = image;
            Compagnie = compagnie;
            CapaciteSpecial = capaciteSpeciale;
        }

        const double POURCENTAGE = 20f / 100;
        /// <summary>
        /// Traitement de l'héro, ajout tenue, armes
        /// </summary>
        public Heros TraitementStats(Arme armeChoisi, Arme armeChoisi2, Tenue tenueChoisi, Heros heros)
        {
            //Changement des stats de l'héros en fonction de la tenue et des armes

            //Tenues Stat
            heros.NvVie += Convert.ToInt32(POURCENTAGE * tenueChoisi.NvDefense);
            heros.Agilite -= Convert.ToInt32(POURCENTAGE * tenueChoisi.Poids);

            //Armes Stat
            if (armeChoisi.NomArme == "bouclier")
            {
                heros.NvVie += Convert.ToInt32(POURCENTAGE * armeChoisi.Durabilite);
            }
            else if (armeChoisi2.NomArme == "bouclier")
            {
                heros.NvVie += Convert.ToInt32(POURCENTAGE * armeChoisi2.Durabilite);
            }

            heros.Attaque += armeChoisi.NvAttaque;
            if (heros.Arme1 != heros.Arme2)
            {
                heros.Attaque += armeChoisi2.NvAttaque;
            }
            return heros;
        }
        /// <summary>
        /// Calcul des dégats totals de l'héros en prenant compte des armes
        /// </summary>
        /// <returns>Niveau d'attaque de l'héro</returns>
        public int Degats()
        {
            int attaqueHero = 0;
            if (Arme1 != Arme2)
            {
                attaqueHero += Attaque + Arme1.Degats();
                attaqueHero += Attaque + Arme2.Degats();
            }
            else
            {
                attaqueHero += Attaque + Arme1.Degats();
            }
            return attaqueHero;
        }
        /// <summary>
        /// Calcul des dégats totaux subis
        /// </summary>
        /// <param name="degatsTotaux">degats sans modification</param>
        public void PerteVie(int degatsTotaux)
        {
            if (this.Defense)
            {
                degatsTotaux += Convert.ToInt32(degatsTotaux / 2);
            }
            else if (this.DefenseSpeciale)
            {
                degatsTotaux += Convert.ToInt32(degatsTotaux / 4);
            }
            this.NvVie -= degatsTotaux;
        }
    }
}
