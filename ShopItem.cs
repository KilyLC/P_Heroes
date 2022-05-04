using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Heroes.Model;

namespace P_Heroes
{
    public partial class ShopItem : UserControl
    {
        private Objet _objet;
        public Objet Objet { get => _objet; set { _objet = value; MiseAJour(); } }

        private FormPlus _formPlusStats;
        private FormPlus _formPlusDescription;

        public ShopItem()
        {
            InitializeComponent();
        }

        public ShopItem(Objet o) : this()
        {
            this.Objet = o;
        }

        private void MiseAJour() {
            if (_objet == null) return;

            // Mise à jour des composants
            this.lblNom.Text = _objet.Nom;
            this.lblNiveau.Text = _objet.Niveau.ToString();
            this.pbxMiniature.Image = _objet.Miniature;
            this.lblDescription.Text = _objet.Description;
            this.lblStatsGauche.Text = _objet.statistiquesEnTexte(); // Stats de l'arme ou armure

            // Form plus
            this._formPlusStats = new FormPlus(_objet);
            this._formPlusDescription = new FormPlus(_objet);

            // Rareté
            Color border_color = Color.White;
            switch (_objet.Rarete)
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

            this.BackColor = border_color;
        }

        private void btnPlusDescription_Click(object sender, EventArgs e)
        {
            this._formPlusDescription.ShowDialog();
        }

        private void btnPlusStats_Click(object sender, EventArgs e)
        {
            this._formPlusStats.ShowDialog();
        }

        public void DefinirAction(string texte)
        {
            this.btnAction.Text = texte;
        }
    }
}
