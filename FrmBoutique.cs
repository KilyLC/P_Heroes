using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes
{
    public partial class FrmBoutique : Form
    {
        // Constantes
        private const int PADDING = 8;

        // Champs
        private List<ObjetBoutique> _boutique = new List<ObjetBoutique>();
        private List<ObjetBoutique> _inventaire = new List<ObjetBoutique>();
        private InventaireBoutique _inventaire2 = new InventaireBoutique();
        private Compagnie _compagnieCourante = null;
        private int _argent;

        // Propriétés
        public List<ObjetBoutique> Boutique { get => _boutique; set { _boutique = value; AfficherBoutique(value, PADDING); } }
        public List<ObjetBoutique> Inventaire { get => _inventaire2.Objets; set { _inventaire2.Objets = value; AfficherInventaire(value, PADDING); } }
        public int Argent { get => _argent; set { _argent = value; AfficherArgent(value); } }
        public Compagnie CompagnieCourante { get => _compagnieCourante; set => _compagnieCourante = value; }

        public FrmBoutique()
        {
            InitializeComponent();

            _boutique.Add(new ArmeBoutique("Lance", 500, Properties.Resources.lance, "", 1, RareteObjet.Rare, 100, 2));
            _boutique.Add(new ArmeBoutique("Hache", 800, Properties.Resources.hache, "Hache de combat", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new ArmeBoutique("Arc de chasse", 200, Properties.Resources.arc, "", 1, RareteObjet.PeuCommun, 100, 2));
            _boutique.Add(new ArmeBoutique("Arbalète", 200, Properties.Resources.arbalete, "", 1, RareteObjet.PeuCommun, 100, 2));
            _boutique.Add(new ArmeBoutique("Sabre laser", 1000, Properties.Resources.sabre_laser, "Sabre laser d'anakin", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new ArmeBoutique("Epee", 500, Properties.Resources.epee, "Epee de chevalier redoutable", 1, RareteObjet.Rare, 100, 2));
            _boutique.Add(new ArmeBoutique("Dague très usée", 100, Properties.Resources.dague, "Dague du maitre très usée", 1, RareteObjet.Commun, 100, 2));
            _boutique.Add(new ArmeBoutique("Dague", 800, Properties.Resources.dague, "Dague du maitre", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new ArmeBoutique("Dague aiguisée", 1000, Properties.Resources.dague, "Dague du maitre aiguisée", 1, RareteObjet.Legendaire, 100, 2));

            // Fleau darme
            _boutique.Add(new ArmeBoutique("Fléau d'arme", 700, Properties.Resources.fleau_darme, "Fléau d'arme", 1, RareteObjet.Rare, 100, 2));
            // Nunchaku
            _boutique.Add(new ArmeBoutique("Nunchaku", 400, Properties.Resources.nunchaku, "Nunchaku traditionnel", 1, RareteObjet.PeuCommun, 100, 2));
            // Fouet
            _boutique.Add(new ArmeBoutique("Fouet", 300, Properties.Resources.fouet, "Fouet western", 1, RareteObjet.PeuCommun, 100, 2));
            // Faux
            _boutique.Add(new ArmeBoutique("Faux", 850, Properties.Resources.faux, "Faux de la mort", 1, RareteObjet.TresRare, 100, 2));
            // batte cloutee
            _boutique.Add(new ArmeBoutique("Batte cloutée", 300, Properties.Resources.batte_cloutee, "Batte cloutée", 1, RareteObjet.PeuCommun, 100, 2));
            // Bouteille cassée
            _boutique.Add(new ArmeBoutique("Bouteille cassée", 100, Properties.Resources.bouteille_cassee, "Bouteille de fêteur", 1, RareteObjet.Commun, 100, 2));
            // Coussin
            _boutique.Add(new ArmeBoutique("Coussin", 100, Properties.Resources.coussin, "Arme pas très efficace...", 1, RareteObjet.Commun, 100, 2));
            // Trident
            _boutique.Add(new ArmeBoutique("Trident", 700, Properties.Resources.trident, "Trident", 1, RareteObjet.Rare, 100, 2));
            // Couteau
            _boutique.Add(new ArmeBoutique("Couteau", 100, Properties.Resources.couteau, "Couteau de cuisine", 1, RareteObjet.Commun, 100, 2));
            // Ceinture
            _boutique.Add(new ArmeBoutique("Ceinture", 100, Properties.Resources.ceinture, "Ceinture 1m", 1, RareteObjet.Commun, 100, 2));

            _boutique.Add(new TenueBoutique("Armure", 200, Properties.Resources.tissu, "Armure de tissu", 1, RareteObjet.Commun, 100, 5));
            _boutique.Add(new TenueBoutique("Armure", 800, Properties.Resources.cuir, "Armure de cuir", 1, RareteObjet.Rare, 100, 5));
            _boutique.Add(new TenueBoutique("Armure", 2000, Properties.Resources.metal, "Armure de metal", 1, RareteObjet.Legendaire, 100, 5));
            _boutique.Add(new ArmeBoutique("Bouclier", 200, Properties.Resources.bouclier, "Bouclier commun", 1, RareteObjet.Commun, 100, 2));

            _inventaire2.Objets.Add(new ArmeBoutique("Arc de chasse", 100, Properties.Resources.arc, "", 3, RareteObjet.Commun, 100, 2));
            _inventaire2.Objets.Add(new ArmeBoutique("Bouclier", 200, Properties.Resources.bouclier, "Bouclier commun", 1, RareteObjet.Commun, 100, 2));

            // Met à jour chaque élément
            this.Boutique = _boutique;
        }

        public FrmBoutique(Compagnie compagnie) : this()
        {
            _compagnieCourante = compagnie;

            List<ObjetBoutique> invent = new List<ObjetBoutique>();
            foreach (Arme a in _compagnieCourante.Inventaire.Armes) { invent.Add(a.ConvertirEnArmeBoutique()); }
            foreach (Tenue t in _compagnieCourante.Inventaire.Tenues) { invent.Add(t.ConvertirEnTenueBoutique()); }

            // Met à jour chaque élément
            this.Inventaire = invent;
            this.Argent = CompagnieCourante.Po;
        }

        // Affiche l'argent en haut à gauche
        public void AfficherArgent(int argent)
        {
            this.lblArgent.Text = argent.ToString() + "Po";
        }

        private void AfficherBoutique(List<ObjetBoutique> objets, int padding)
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

            // Affiche 3 items par ligne
            foreach (ObjetBoutique o in objets)
            {
                ShopItem shi = new ShopItem(counter, o, OnBuy);
                shi.DefinirAction("Acheter pour " + o.CalculPrix() + "Po");
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
        private void AfficherInventaire(List<ObjetBoutique> objets, int padding)
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

            // Affiche 3 items par ligne
            foreach (ObjetBoutique o in objets)
            {
                ShopItem shi = new ShopItem(counter, o, OnSell);
                shi.DefinirAction("Vendre pour " + o.CalculPrixVente() + "Po");
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

        // Enlève tout les contrôles de l'onglet
        private void ViderBoutique()
        {
            /*
            foreach (Control c in tpgAcheter.Controls)
                if (c is ShopItem)
                        tpgAcheter.Controls.Remove(c);
            */
            tpgAcheter.Controls.Clear();
        }

        // Enlève tout les contrôles de l'onglet
        private void ViderInventaire()
        {
            /*
            foreach (Control c in tpgVendre.Controls)
                if (c is ShopItem)
                    tpgVendre.Controls.Remove(c);
            */
            tpgVendre.Controls.Clear(); // Label détruit
        }

        // Lors d'un clic sur un bouton acheter
        private void OnBuy(object _sender, EventArgs e)
        {
            if (!(_sender is Button))
                return;
            Button sender = (Button)_sender;

            // Récupérer le user control du bouton cliqué
            // pour pouvoir récupérer l'index du contrôle cliqué dans la liste
            int idx = ((ShopItem)sender.Parent.Parent).Idx;
            ObjetBoutique item = _boutique[idx];

            // A modifier avec l'argent global du jeu
            if (CompagnieCourante.Po >= item.CalculPrix())
            {
                if (item is ArmeBoutique)
                {
                    Arme a = new Arme();
                    a.CreeArme(item.Durabilite, ((ArmeBoutique)item).DegatsMin, ((ArmeBoutique)item).DegatsMax, item.Nom, item.Miniature, ((ArmeBoutique)item).NbMains, item.Prix, item.Niveau, item.Rarete);
                    CompagnieCourante.Inventaire.Armes.Add(a);
                }
                else if (item is TenueBoutique)
                {
                    Tenue t = new Tenue();
                    t.CreeTenue(item.Nom, ((TenueBoutique)item).ProtectionMax, ((TenueBoutique)item).Poids, item.Miniature);
                    CompagnieCourante.Inventaire.Tenues.Add(t);
                }

                CompagnieCourante.Po -= item.CalculPrix();

                List<ObjetBoutique> objets = new List<ObjetBoutique>();
                foreach (Arme a in CompagnieCourante.Inventaire.Armes) { objets.Add(a.ConvertirEnArmeBoutique()); }
                foreach (Tenue t in CompagnieCourante.Inventaire.Tenues) { objets.Add(t.ConvertirEnTenueBoutique()); }

                // Actualiser inventaire et boutique
                this.Boutique = _boutique;
                this.Inventaire = objets; // objets;

                this.Argent = CompagnieCourante.Po;
            }
        }

        // Lors d'un clic sur le bouton vendre
        private void OnSell(object _sender, EventArgs e)
        {
            if (!(_sender is Button))
                return;

            Button sender = (Button)_sender;

            // Récupérer le user control du bouton cliqué
            // pour pouvoir récupérer l'index du contrôle cliqué dans la liste
            int idx = ((ShopItem)sender.Parent.Parent).Idx;

            // Ce code permet de savoir si il faut enlever l'item dans les armes de la compagnie
            // ou dans les tenues et ensuite calcule l'index
            bool estTenue = false;
            if (idx >= CompagnieCourante.Inventaire.Armes.Count)
            {
                estTenue = true;
                idx -= CompagnieCourante.Inventaire.Armes.Count;
            }

            // Récupérer item
            ObjetBoutique item;
            if (estTenue)
                item = CompagnieCourante.Inventaire.Tenues[idx].ConvertirEnTenueBoutique();
            else
                item = CompagnieCourante.Inventaire.Armes[idx].ConvertirEnArmeBoutique();

            // Confirmation
            if (MessageBox.Show("Confirmation", "Êtes-vous sur de vouloir vendre \"" + item.Nom + "\"?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            
            CompagnieCourante.Po += item.CalculPrixVente();

            if (estTenue)
                CompagnieCourante.Inventaire.Tenues.RemoveAt(idx);
            else
                CompagnieCourante.Inventaire.Armes.RemoveAt(idx);

            List<ObjetBoutique> objets = new List<ObjetBoutique>();
            foreach (Arme a in CompagnieCourante.Inventaire.Armes) { objets.Add(a.ConvertirEnArmeBoutique()); }
            foreach (Tenue t in CompagnieCourante.Inventaire.Tenues) { objets.Add(t.ConvertirEnTenueBoutique()); }

            // Actualiser inventaire et boutique
            this.Boutique = _boutique;
            this.Inventaire = objets;
            this.Argent = CompagnieCourante.Po;
        }
    }
}
