/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Arme 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace P_Heroes
{
    public class Arme
    {
        private int _niveau = 1;
        private RareteObjet _rarete = RareteObjet.Commun;

        public string NomArme { get; set; }
        public int NvAttaque { get; set; }
        public int NvAttaqueMax { get; set; }
        public int NvAttaqueMin { get; set; }
        public int Durabilite { get; set; }
        public int NbMains { get; set; }
        public Image Image { get; set; }
        public string Description { get; set; }
        public int Niveau { get => _niveau; set => _niveau = value; }
        public RareteObjet Rarete { get => _rarete; set => _rarete = value; }
        public int Prix { get; set; }

        Random rnd = new Random();
        
        /// <summary>
        /// Créer les armes
        /// </summary>
        public void CreeArme(int durabilite, int attaqueMin, int attaqueMax, string nomArme, Image image, int nbMains, int prix)
        {
            Durabilite = durabilite;
            NvAttaqueMin = attaqueMin;
            NvAttaqueMax = attaqueMax;
            NvAttaque = Degats();
            NbMains= nbMains;
            NomArme = nomArme;
            Image = image;
            Prix = prix;
        }

        /// <summary>
        /// Créer les armes
        /// </summary>
        public void CreeArme(int durabilite, int attaqueMin, int attaqueMax, string nomArme, Image image, int nbMains, int prix, int niveau, RareteObjet rarete)
        {
            Durabilite = durabilite;
            NvAttaqueMin = attaqueMin;
            NvAttaqueMax = attaqueMax;
            NvAttaque = Degats();
            NbMains = nbMains;
            NomArme = nomArme;
            Image = image;
            Prix = prix;

            _niveau = niveau;
            _rarete = rarete;
        }

        /// <summary>
        /// Calcul du nombre de dégat de l'arme de manière aléatoire
        /// </summary>
        /// <returns>Le nombre de dégats</returns>
        public int Degats()
        {
            return rnd.Next(this.NvAttaqueMin, this.NvAttaqueMax + 1);  
        }
         
        public ArmeBoutique ConvertirEnArmeBoutique()
        {
            return new ArmeBoutique(NomArme, Prix, Image, Description, Niveau, Rarete, Durabilite, NbMains);
        }
    }
}
