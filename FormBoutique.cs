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
        private const int PADDING = 8;
        private List<Objet> _boutique = new List<Objet>();
        private List<Objet> _inventaire = new List<Objet>();
        private int _argent;

        public List<Objet> Boutique { get => _boutique; set { _boutique = value; AfficherBoutique(value, PADDING); } }
        public List<Objet> Inventaire { get => _inventaire; set { _inventaire = value; AfficherInventaire(value, PADDING); } }
        public int Argent { get => _argent; set { _argent = value; AfficherArgent(value); } }

        private List<Objet> nouvelleBoutique = new List<Objet>();
        private List<Objet> inventaire = new List<Objet>();

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

            ViderBoutique();

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
        private void AfficherInventaire(List<Objet> objets, int padding)
        {
            if (objets == null)
                return;

            ViderInventaire();

            // Padding
            int padx = padding;
            int pady = padding;
            // Position
            int x = padx;
            int y = pady;
            // Compteur d'objets
            int counter = 0;

            if (objets.Count == 0)
                lblInventaireVide.Visible = true;
            else
                lblInventaireVide.Visible = false;

            foreach (Objet o in objets)
            {
                ShopItem shi = new ShopItem(counter, o, OnSell);
                shi.DefinirAction("Vendre pour " + o.calculPrixVente() + "$");
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

        private void ViderBoutique()
        {
            /*
            foreach (Control c in tpgAcheter.Controls)
                if (c is ShopItem)
                        tpgAcheter.Controls.Remove(c);
            */
            tpgAcheter.Controls.Clear();
        }

        private void ViderInventaire()
        {
            /*
            foreach (Control c in tpgVendre.Controls)
                if (c is ShopItem)
                    tpgVendre.Controls.Remove(c);
            */
            tpgVendre.Controls.Clear();
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
            
            // A modifier avec l'argent global du jeu
            if (Argent >= item.calculPrix())
            {
                inventaire.Add(item);
                Argent -= item.calculPrix();
                nouvelleBoutique.RemoveAt(idx); // Enlever de la boutique

                // Actualiser inventaire et boutique
                AfficherBoutique(nouvelleBoutique, 8);
                AfficherInventaire(nouvelleBoutique, 8);

                // Actualiser inventaire et boutique
                this.Boutique = nouvelleBoutique;
                this.Inventaire = inventaire;
            }
        }

        private void OnSell(object _sender, EventArgs e)
        {
            if (!(_sender is Button))
                return;

            Button sender = (Button)_sender;

            // Récupérer le user control du bouton cliqué
            // pour pouvoir récupérer l'index du contrôle cliqué dans la liste
            int idx = ((ShopItem)sender.Parent.Parent).Idx;
            Objet item = inventaire[idx];

            // Confirmation
            if (MessageBox.Show("Confirmation", "Êtes-vous sur de vouloir vendre \"" + item.Nom + "\"?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            // TODO: VERIFIER SI L'ITEM PEUT REVENIR DANS LA BOUTIQUE

            Argent += item.calculPrixVente();
            inventaire.RemoveAt(idx);

            // Actualiser inventaire et boutique
            this.Boutique = nouvelleBoutique;
            this.Inventaire = inventaire;
        }
    }
}
