using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    /// <summary>
    /// Inventaire du joueur
    /// </summary>
    public class Inventaire
    {
        private List<Arme> _armes;
        private List<Tenue> _tenues;
        public List<Arme> Armes { get => _armes; set => _armes = value; }
        public List<Tenue> Tenues { get => _tenues; set => _tenues = value; }

        public Inventaire()
        {
            Armes = new List<Arme>();
            Tenues = new List<Tenue>();
        }
        /// <summary>
        /// Ajoute l'arme à l'inventaire
        /// </summary>
        /// <param name="arme">L'arme à ajouter</param>
        public void AjoutArme(Arme arme)
        {
            this.Armes.Add(arme);
        }
        /// <summary>
        /// Ajoute la tenue à l'inventaire
        /// </summary>
        /// <param name="tenue">La tenue à ajouter</param>
        public void AjoutTenue(Tenue tenue)
        {
            this.Tenues.Add(tenue);
        }
    }
}
