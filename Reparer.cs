using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Heroes
{
    public class Reparer
    {
        private int _prixTotal;
        private List<Arme> _armeSelect;
        
        public int PrixTotal { get => _prixTotal; set => _prixTotal = value; }
        public List<Arme> ArmeSelect { get => _armeSelect; set => _armeSelect = value; }
        public int DurabiliteMax { get; set; } = 100;        

        public Reparer()
        {
            //init liste armes            
            ArmeSelect = new List<Arme>();
            PrixTotal = 0;
        }
        /// <summary>
        /// Calcul du prix total des armes sélectionnés
        /// </summary>
        private void CalculPrix()
        {
            foreach (Arme a in ArmeSelect)
            {
                double pourcentagePrix = (DurabiliteMax - a.Durabilite) / 100.0;
                double prixFinal = pourcentagePrix * a.Prix;
                PrixTotal += Convert.ToInt32(prixFinal);
            }
        } 

        /// <summary>
        /// Ajoute l'arme à la liste des armes sélectionnés
        /// </summary>
        /// <param name="a">l'Arme à ajouter</param>
        public void AjoutListeArmeSelectionne(Arme a)
        {
            ArmeSelect.Add(a);
            CalculPrix();
        }
        /// <summary>
        /// Rénitialise les armes et le prix
        /// </summary>
        public void Reset()
        {
            PrixTotal = 0;
            ArmeSelect.Clear();
        }
        /// <summary>
        /// Verfie si la compagnie à assez d'argent
        /// </summary>
        /// <returns>Oui/non</returns>
        public bool VerifArgent()
        {
            if (CompagnieStocker.compagnieActuelle.Po < PrixTotal)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Repare les armes et déduit l'argent de la compagnie
        /// </summary>
        public void ReparerArmes()
        {
            foreach (Arme arme in ArmeSelect)
            {
                arme.Durabilite = DurabiliteMax;
            }
            CompagnieStocker.compagnieActuelle.Po -= PrixTotal;
            Reset();
        }
    }
}
