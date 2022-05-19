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
        private EventHandler _callback = null; // Fonction de callback lors d'un clic sur l'action
        private FormPlus _formPlus;

        public int Idx = -1; // Index du contrôle sur la form parent (pour enlever l'item de la liste)

        public ShopItem(int idx)
        {
            InitializeComponent();
            Idx = idx;
        }

        public ShopItem(int idx, Objet o) : this(idx)
        {
            this.Objet = o;
        }

        public ShopItem(int idx, Objet o, EventHandler callback) : this(idx, o)
        {
            this._callback = callback;
        }

        private void MiseAJour() {
            if (_objet == null) return;

            // Mise à jour des composants
            this.lblNom.Text = _objet.Nom;
            this.lblNiveau.Text = _objet.Niveau.ToString();
            this.pbxMiniature.Image = _objet.Miniature;
            this.lblDescription.Text = _objet.Description;
            this.lblStatsGauche.Text = _objet.StatistiquesEnTexte(); // Stats de l'arme ou armure

            // Form plus
            this._formPlus = new FormPlus(_objet);

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

        public void DefinirAction(string texte)
        {
            this.btnAction.Text = texte;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            this._formPlus.ShowDialog();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (_callback == null)
                return;

            _callback(sender, e);
        }
    }
}
