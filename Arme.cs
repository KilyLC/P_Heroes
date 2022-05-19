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
    /// <summary>
    /// Une ar
    /// </summary>
    public class Arme
    {
        public string NomArme { get; set; }
        public int NvAttaque { get; set; }
        public int NvAttaqueMax { get; set; }
        public int NvAttaqueMin { get; set; }
        public int Durabilite { get; set; }
        public int NbMains { get; set; }
        public Image Image { get; set; }

        Random rnd = new Random();
        
        /// <summary>
        /// Créer les armes
        /// </summary>
        public void CreeArme(int durabilite, int attaqueMin,int attaqueMax, string nomArme, Image image, int nbMains)
        {
            Durabilite = durabilite;
            NvAttaqueMin = attaqueMin;
            NvAttaqueMax = attaqueMax;
            NvAttaque = Degats();
            NbMains= nbMains;
            NomArme = nomArme;
            Image = image;
        }
        /// <summary>
        /// Calcul du nombre de dégat de l'arme de manière aléatoire
        /// </summary>
        /// <returns>Le nombre de dégats</returns>
        public int Degats()
        {
            return rnd.Next(this.NvAttaqueMin, this.NvAttaqueMax + 1);
        }

    }
}
