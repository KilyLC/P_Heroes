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
        public Objet objet;
        public Objet Objet { get => objet; set { objet = value; miseAJour(); } }

        public ShopItem()
        {
            InitializeComponent();
        }
        public void miseAJour() {
            // Mise à jour des composants
            this.lblNom.Text = objet.Nom;
            this.pbxMiniature.Image = objet.Miniature;
            this.lblDescription.Text = objet.Description;
            this.lblStatsGauche.Text = objet.statistiqueEnText();
            this.btnAction.Text = objet.calculPrix().ToString();
        }
    }
}
