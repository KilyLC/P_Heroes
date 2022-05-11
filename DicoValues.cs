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
        public DicoValues(Arme arme, bool utilisee)
        {
            this.arme = arme;
            this.utiliseeArme = utilisee;
        }
        public DicoValues(Tenue tenue, bool utilisee)
        {
            this.tenue = tenue;
            this.utiliseeTenue = utilisee;
        }

        public Arme arme { get; set; }
        public Tenue tenue { get; set; }
        public bool utiliseeArme { get; set; }
        public bool utiliseeTenue { get; set; }
    }
}
