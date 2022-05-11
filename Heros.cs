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
        internal Tenue Tenue { get => _tenue; set => _tenue = value; }
        internal Arme Arme1 { get => _arme1; set => _arme1 = value; }
        internal Arme Arme2 { get => _arme2; set => _arme2 = value; }
        internal Compagnie Compagnie { get => _compagnie; set => _compagnie = value; }
        
        public void CreeHero(int nvVie, int agilite, int attaque, string nomHero, Image image, bool vivant, Compagnie compagnie)
        {
            Agilite = agilite;
            Attaque = attaque;
            NvVie = nvVie;
            NomHeros = nomHero;
            Vivant = vivant;
            ImageHero = image;
            Compagnie = compagnie;
        }

        const double POURCENTAGE = 20f / 100;
        /// <summary>
        /// Traitement de l'héro, ajout tenue, armes
        /// </summary>
        public Heros TraitementHeros(Arme armeChoisi, Arme armeChoisi2, Tenue tenueChoisi, Heros heros)
        {
            //Assigner les armes choisies à l'héros concerné 
            if (armeChoisi.NbMains == 1 && armeChoisi2.NbMains == 1)
            {
                heros.Arme1 = armeChoisi;
                heros.Arme2 = armeChoisi2;
            }
            else
            {
                heros.Arme1 = armeChoisi;
                heros.Arme2 = armeChoisi;
            }
            //Assigner la tenue à l'héros concerné
            heros.Tenue = tenueChoisi;


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
        //public void Heros1(string nomHeros)
        //{
        //    Agilite = 70;
        //    Attaque = 60;
        //    NvVie = 100;
        //    NomHeros = nomHeros;
        //    Vivant = true;
        //    ImageHero = Properties.Resources.Hero1;
        //}
        //public void Heros2(string nomHeros)
        //{
        //    Agilite = 50;
        //    Attaque = 40;
        //    NvVie = 100;
        //    Vivant = true;
        //    NomHeros = nomHeros;
        //    ImageHero = Properties.Resources.Hero2;
        //}
        //public void Heros3(string nomHeros)
        //{
        //    Agilite = 40;
        //    Attaque = 30;
        //    NvVie = 100;
        //    Vivant = true;
        //    NomHeros = nomHeros;
        //    ImageHero = Properties.Resources.Hero3;
        //}
        //public void Ennemi1(string nomHeros)
        //{
        //    Agilite = 40;
        //    Attaque = 20;
        //    NvVie = 100;
        //    NomHeros = nomHeros;
        //    Vivant = true;
        //    ImageHero = Properties.Resources.OrcArcherCuir;
        //}
        //public void Ennemi2(string nomHeros)
        //{
        //    Agilite = 10;
        //    Attaque = 50;
        //    NvVie = 100;
        //    Vivant = true;
        //    NomHeros = nomHeros;
        //    ImageHero = Properties.Resources.Orc_Warriors_Armor_Shield;
        //}
        //public void Ennemi3(string nomHeros)
        //{
        //    Agilite = 60;
        //    Attaque = 30;
        //    NvVie = 100;
        //    Vivant = true;
        //    NomHeros = nomHeros;
        //    ImageHero = Properties.Resources.OrcArcherCuir;
        //}
    }
}
