using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using P_Heroes.Model;

namespace P_Heroes
{
    public partial class FormBoutique : Form
    {
        List<Objet> _boutique = new List<Objet>();
        List<Objet> _inventaire = new List<Objet>();
        public List<Objet> Boutique { get => _boutique; set { _boutique = value; AfficherBoutique(value); } }
        public List<Objet> Inventaire { get => _inventaire; set { _inventaire = value; AfficherInventaire(value); } }

        public FormBoutique()
        {
            InitializeComponent();

            List<Objet> nouvelleBoutique = new List<Objet>();
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));

            List<Objet> inventaire = new List<Objet>();
            inventaire.Add(new P_Heroes.Model.Arme("Arc de chasse", 100, Properties.Resources.arc, "", 3, 100, 1, 2));

            this.Boutique = nouvelleBoutique;
            this.Inventaire = inventaire;
        }

        public void AfficherArgent(int argent)
        {
            this.lblArgent.Text = argent.ToString() + "$";
        }

        private void AfficherBoutique(List<Objet> objets)
        {
            if (objets == null)
                return;

            // Padding
            int padx = 8;
            int pady = 8;
            // Position
            int x = padx;
            int y = pady;
            // Compteur d'objets
            int counter = 0;

            foreach (Objet o in objets)
            {
                ShopItem shi = new ShopItem(o);
                shi.DefinirAction("Acheter");
                shi.Location = new Point(x, y);

                tpgAcheter.Controls.Add(shi);

                counter += 1;
                if (counter % 3 != 0)
                {
                    x += shi.Size.Width + padx;
                }
                else
                {
                    x = padx;
                    y += shi.Size.Height + pady;
                }
            }
        }
        private void AfficherInventaire(List<Objet> objets)
        {
            if (objets == null)
                return;

            // Padding
            int padx = 8;
            int pady = 8;
            // Position
            int x = padx;
            int y = pady;
            // Compteur d'objets
            int counter = 0;

            foreach (Objet o in objets)
            {
                ShopItem shi = new ShopItem(o);
                shi.DefinirAction("Vendre");
                shi.Location = new Point(x, y);

                tpgVendre.Controls.Add(shi);

                counter += 1;
                if (counter % 3 != 0)
                {
                    x += shi.Size.Width + padx;
                }
                else
                {
                    x = padx;
                    y += shi.Size.Height + pady;
                }
            }
        }
    }
}
