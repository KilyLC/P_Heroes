using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes.Model
{
    public partial class FrmInventaire : Form
    {
        private List<ObjetBoutique> _objets = new List<ObjetBoutique>();
        private ObjetBoutique _objetSelec = null;
        private ObjetInventaire _controleObjetSelec = null; // Garde une référence de l'ancien contrôle cliqué (pour ensuite enlever la bordure)
        private Inventaire _inventaire;
        public List<ObjetBoutique> Objets { get => _objets; set { _objets = value; AfficherObjetsDispo(value); } }
        public ObjetBoutique ObjetSelec { get => _objetSelec; set { _objetSelec = value; AfficherObjet(value);  } }
        public ObjetInventaire ControleObjetSelec { get => _controleObjetSelec; set => _controleObjetSelec = value; }

        public FrmInventaire()
        {
            InitializeComponent();
            ViderSelection();

            pnlRarete.BringToFront(); // Afficher la bordure au dessus
        }
        
        // Pour pouvoir communiquer avec un inventaire
        public FrmInventaire(Inventaire inventaire) : this()
        {
            _inventaire = inventaire;

            // Convertir tout les items en objets de boutique
            List<ObjetBoutique> objets = new List<ObjetBoutique>();
            foreach (Arme a in inventaire.Armes) { objets.Add(a.ConvertirEnArmeBoutique()); }
            foreach (Tenue t in inventaire.Tenues) { objets.Add(t.ConvertirEnTenueBoutique()); }

            _objets = objets;
            Objets = _objets;
        }

        public void AfficherDescription(string texte)
        {
            lblDescriptionSelec.Text = texte;
        }

        public void AfficherStats(string stats)
        {
            lblStatsSelec.Text = stats;
        }

        public void AfficherPrix(int prix)
        {
            btnVendre.Text = "Vendre objet (" + prix + "Po)";
        }

        public void AfficherMiniature(Image miniature)
        {
            pbxObjetSelec.Image = miniature;
        }

        public void AfficherRarete(RareteObjet rarete)
        {
            Color border_color = Color.White;
            switch (rarete)
            {
                case RareteObjet.Commun:
                    border_color = Color.Gray; break;
                case RareteObjet.PeuCommun:
                    border_color = Color.LimeGreen; break;
                case RareteObjet.Rare:
                    border_color = Color.DeepSkyBlue; break;
                case RareteObjet.TresRare:
                    border_color = Color.Magenta; break;
                case RareteObjet.Legendaire:
                    border_color = Color.Gold; break;
            }

            pnlRarete.BackColor = border_color;
        }

        public void AfficherNiveauObjet(int niveau)
        {
            lblNiveauSelec.Text = niveau.ToString();
        }

        public void AfficherNomObjet(string nom)
        {
            lblNomSelec.Text = nom;
        }
        
        // Combine toutes les fonctions pour afficher un objet
        public void AfficherObjet(ObjetBoutique o)
        {
            AfficherNiveauObjet(o.Niveau);
            AfficherMiniature(o.Miniature);
            AfficherRarete(o.Rarete);
            AfficherNomObjet(o.Nom);
            AfficherDescription(o.Description);
            AfficherStats(o.StatistiquesEnTexte());
            AfficherPrix(o.CalculPrixVente());
        }

        public void AfficherObjetsDispo(List<ObjetBoutique> objets)
        {
            int x = 0;
            int y = 0;
            int counter = 0;
            foreach (ObjetBoutique o in objets)
            {
                if (o.Nom == "Arbalète")
                {
                    int a = 1;
                }

                ObjetInventaire minia = new ObjetInventaire(o); // Créer une nouvelle miniature d'objet
                minia.DefinirEventHandler(OnItemClick); // Fonction callback
                minia.Idx = counter;
                counter += 1;

                minia.Location = new Point(x, y);
                pnlItems.Controls.Add(minia);

                x += minia.Size.Width;
                if (x + minia.Size.Width > pnlItems.Width)
                {
                    y += minia.Size.Height;
                    x = 0;
                }
            }
        }

        public void OnItemClick(object _sender, EventArgs e)
        {
            if (!(_sender is ObjetInventaire))
                return;

            // Cast
            ObjetInventaire sender = (ObjetInventaire)_sender;

            // Protection lorsque l'on clique sur le même item
            if (sender == ControleObjetSelec)
                return;

            // Afficher bordure item
            sender.BorderStyle = BorderStyle.FixedSingle;

            // Récupérer le user control du bouton cliqué
            // pour pouvoir récupérer l'index du contrôle cliqué dans la liste
            int idx = sender.Idx;
            ObjetBoutique item = Objets[idx];

            // Enlever ancienne bordure
            if (ControleObjetSelec != null)
                ControleObjetSelec.BorderStyle = BorderStyle.None;

            // Changer la référence d'objet sélectionné
            ObjetSelec = item;
            ControleObjetSelec = sender;
        }

        private void ViderSelection()
        {
            pbxObjetSelec.Image = null;
            lblNiveauSelec.Text = "";
            lblNomSelec.Text = "";
            lblDescriptionSelec.Text = "";
            lblStatsSelec.Text = "";
            btnVendre.Text = "";
        }

        private List<ObjetBoutique> Populate()
        {
            List<ObjetBoutique> _boutique = new List<ObjetBoutique>();
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Lance", 500, Properties.Resources.lance, "", 1, RareteObjet.Rare, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Hache", 800, Properties.Resources.hache, "Hache de combat", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Arc de chasse", 200, Properties.Resources.arc, "", 1, RareteObjet.PeuCommun, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Arbalète", 200, Properties.Resources.arbalete, "", 1, RareteObjet.PeuCommun, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Sabre laser", 1000, Properties.Resources.sabre_laser, "Sabre laser d'anakin", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Epee", 500, Properties.Resources.epee, "Epee de chevalier redoutable", 1, RareteObjet.Rare, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Dague très usée", 100, Properties.Resources.dague, "Dague du maitre très usée", 1, RareteObjet.Commun, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Dague", 800, Properties.Resources.dague, "Dague du maitre", 1, RareteObjet.TresRare, 100, 2));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Dague aiguisée", 1000, Properties.Resources.dague, "Dague du maitre aiguisée", 1, RareteObjet.Legendaire, 100, 2));

            // Fleau darme
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Fléau d'arme", 700, Properties.Resources.fleau_darme, "Fléau d'arme", 1, RareteObjet.Rare, 100, 2));
            // Nunchaku
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Nunchaku", 400, Properties.Resources.nunchaku, "Nunchaku traditionnel", 1, RareteObjet.PeuCommun, 100, 2));
            // Fouet
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Fouet", 300, Properties.Resources.fouet, "Fouet western", 1, RareteObjet.PeuCommun, 100, 2));
            // Faux
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Faux", 850, Properties.Resources.faux, "Faux de la mort", 1, RareteObjet.TresRare, 100, 2));
            // batte cloutee
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Batte cloutée", 300, Properties.Resources.batte_cloutee, "Batte cloutée", 1, RareteObjet.PeuCommun, 100, 2));
            // Bouteille cassée
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Bouteille cassée", 100, Properties.Resources.bouteille_cassee, "Bouteille de fêteur", 1, RareteObjet.Commun, 100, 2));
            // Coussin
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Coussin", 100, Properties.Resources.coussin, "Arme pas très efficace...", 1, RareteObjet.Commun, 100, 2));
            // Trident
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Trident", 700, Properties.Resources.trident, "Trident", 1, RareteObjet.Rare, 100, 2));
            // Couteau
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Couteau", 100, Properties.Resources.couteau, "Couteau de cuisine", 1, RareteObjet.Commun, 100, 2));
            // Ceinture
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Ceinture", 100, Properties.Resources.ceinture, "Ceinture 1m", 1, RareteObjet.Commun, 100, 2));

            _boutique.Add(new P_Heroes.Model.TenueBoutique("Armure", 200, Properties.Resources.tissu, "Armure de tissu", 1, RareteObjet.Commun, 100, 5));
            _boutique.Add(new P_Heroes.Model.TenueBoutique("Armure", 800, Properties.Resources.cuir, "Armure de cuir", 1, RareteObjet.Rare, 100, 5));
            _boutique.Add(new P_Heroes.Model.TenueBoutique("Armure", 2000, Properties.Resources.metal, "Armure de metal", 1, RareteObjet.Legendaire, 100, 5));
            _boutique.Add(new P_Heroes.Model.ArmeBoutique("Bouclier", 200, Properties.Resources.bouclier, "Bouclier commun", 1, RareteObjet.Commun, 100, 2));
            return _boutique;
        }
    }
}
