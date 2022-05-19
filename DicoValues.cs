/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class DicoValues
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    /// <summary>
    /// Valeurs du dictionnaire d'armes
    /// </summary>
    public class DicoValues
    {
        public Arme arme { get; set; }
        public Tenue tenue { get; set; }
        public bool utiliseeArme { get; set; }
        public bool utiliseeTenue { get; set; }

        /// <summary>
        /// Constructeur pour les armes
        /// </summary>
        /// <param name="arme">l'arme</param>
        /// <param name="utilisee">Arme utilise</param>
        public DicoValues(Arme arme, bool utilisee)
        {
            this.arme = arme;
            this.utiliseeArme = utilisee;
        }
        /// <summary>
        /// Constructeur pour les tenues
        /// </summary>
        /// <param name="tenue">La tenue</param>
        /// <param name="utilisee">Tenue utilise</param>
        public DicoValues(Tenue tenue, bool utilisee)
        {
            this.tenue = tenue;
            this.utiliseeTenue = utilisee;
        }

    }
}
