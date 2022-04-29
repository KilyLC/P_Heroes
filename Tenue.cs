/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Tenue
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    class Tenue
    {
        private string _nomTenue;
        private int _nvDefense;
        private int _poids;

        public string NomTenue { get => _nomTenue; set => _nomTenue = value; }
        public int NvDefense { get => _nvDefense; set => _nvDefense = value; }
        public int Poids { get => _poids; set => _poids = value; }


        //tenue 1 
        const string TENUE1 = "tissu";
        const int POIDS_TENUE1 = 10;
        const int NIV_DEFENSE_1 = 20;
        //tenue 2 
        const string TENUE2 = "cuir";
        const int POIDS_TENUE2 = 30;
        const int NIV_DEFENSE_2 = 40;
        //tenue 3
        const string TENUE3 = "metal";
        const int POIDS_TENUE3 = 70;
        const int NIV_DEFENSE_3 = 40;

        public Tenue()
        {
            
        }
        /// <summary>
        /// Ajoute les stats à la tenue choisie
        /// </summary>
        public Tenue majTenue(string nomTenue)
        {
            Tenue tenue = new Tenue();
            if (nomTenue == TENUE1)
            {
                tenue.NomTenue = TENUE1;
                tenue.Poids = POIDS_TENUE1;
                tenue.NvDefense = NIV_DEFENSE_1;
            }
            else if (nomTenue == TENUE2)
            {
                tenue.NomTenue = TENUE2;
                tenue.Poids = POIDS_TENUE2;
                tenue.NvDefense = NIV_DEFENSE_2;
            }
            else if (nomTenue == TENUE3)
            {
                tenue.NomTenue = TENUE3;
                tenue.Poids = POIDS_TENUE3;
                tenue.NvDefense = NIV_DEFENSE_3;
            }
            return tenue;
        }
    }
}
