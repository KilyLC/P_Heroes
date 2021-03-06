/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Class Tenue
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public class Tenue
    {
        private string _nomTenue;
        private int _nvDefense;
        private int _poids;

        public string NomTenue { get => _nomTenue; set => _nomTenue = value; }
        public int NvDefense { get => _nvDefense; set => _nvDefense = value; }
        public int Poids { get => _poids; set => _poids = value; }
        public Image ImageTenue { get; set; }

        public int Prix { get; set; }
        public int Niveau { get; set; }
        public string Description { get; set; }
        public RareteObjet Rarete { get; set; }
        public int Durabilite { get; set; }

        /// <summary>
        /// Créer la tenue
        /// </summary>
        public void CreeTenue(string nomTenue, int nvDef, int poids, Image imageTenue)
        {
            this.NomTenue = nomTenue;
            this.NvDefense = nvDef;
            this.Poids = poids;
            this.ImageTenue = imageTenue;
        }

        public TenueBoutique ConvertirEnTenueBoutique()
        {
            return new TenueBoutique(NomTenue, Prix, ImageTenue, Description, 1, Rarete, 100, Poids);
        }
    }
}
