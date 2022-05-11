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
        private List<Objet> _boutique = new List<Objet>();
        private List<Objet> _inventaire = new List<Objet>();
        private int _argent;

        public List<Objet> Boutique { get => _boutique; set { _boutique = value; AfficherBoutique(value, 8); } }
        public List<Objet> Inventaire { get => _inventaire; set { _inventaire = value; AfficherInventaire(value); } }
        public int Argent { get => _argent; set { _argent = value; AfficherArgent(value); } }

        private List<Objet> nouvelleBoutique = new List<Objet>();

        public FormBoutique()
        {
            InitializeComponent();
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Epee", 100, Properties.Resources.epee, "Epee de chevalier redoutable", 6, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague usée", 100, Properties.Resources.dague, "Dague du maitre très usée", 2, 100, 1, 15));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 100, Properties.Resources.dague, "Dague du maitre", 8, 100, 10, 30));
            nouvelleBoutique.Add(new P_Heroes.Model.Arme("Dague", 1000, Properties.Resources.dague, "Dague du maitre améliorée", 9, 100, 20, 40));


            List<Objet> inventaire = new List<Objet>();
            inventaire.Add(new P_Heroes.Model.Arme("Arc de chasse", 50, Properties.Resources.arc, "", 3, 100, 1, 2));
            inventaire.Add(new P_Heroes.Model.Arme("Bouclier", 20, Properties.Resources.bouclier, "Bouclier commun", 1, 100, 10, 30));

            this.Boutique = nouvelleBoutique;
            this.Inventaire = inventaire;
            this.Argent = 50;
        }

        public void AfficherArgent(int argent)
        {
            this.lblArgent.Text = argent.ToString() + "$";
        }

        private void AfficherBoutique(List<Objet> objets, int padding)
        {
            if (objets == null)
                return;

            // Padding
            int padx = padding;
            int pady = padding;
            // Position
            int x = padx;
            int y = pady;
            // Compteur d'objets
            int counter = 0;

            foreach (Objet o in objets)
            {
                ShopItem shi = new ShopItem(counter, o, OnBuy);
                shi.DefinirAction("Acheter pour " + o.calculPrix() + "$");
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
                ShopItem shi = new ShopItem(counter, o);
                shi.DefinirAction("Vendre pour " + o.calculPrix() + "$");
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

        private void OnBuy(object _sender, EventArgs e)
        {
            if (!(_sender is Button))
                return;
            Button sender = (Button)_sender;

            // Récupérer le user control du bouton cliqué
            // pour pouvoir récupérer l'index du contrôle cliqué dans la liste
            int idx = ((ShopItem)sender.Parent.Parent).Idx;
            Objet item = nouvelleBoutique[idx];

            MessageBox.Show(item.Nom.ToString());
            /*
                // A faire
                if (argent >= item.Prix)
                {
                    inventaire.Add(item);
                    argent -= item.Prix;
                    nouvelleBoutique.RemoveAt(idx); // Enlever de la boutique

                    // Actualiser inventaire et boutique
                    AfficherBoutique(nouvelleBoutique, 8);
                    AfficherInventaire(nouvelleBoutique, 8);
                }
            */
        }
    }
}
