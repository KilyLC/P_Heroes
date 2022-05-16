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
    public partial class CarteAffichage : UserControl
    {
        private EventHandler _handler = null;
        private Heros _heros;
        private Arme _arme;
        private Tenue _tenue;
        public CarteAffichage()
        {
            InitializeComponent();
        }
        public CarteAffichage(Heros h)
        {
            this._heros = h;
            InitializeComponent();
        }

        public CarteAffichage(Heros h, EventHandler handler)
        {
            this._handler = handler;
            this._heros = h;
            InitializeComponent();
        }
        public CarteAffichage(Arme a, EventHandler handler)
        {
            this._handler = handler;
            this._arme = a;
            InitializeComponent();
        }
        public CarteAffichage(Tenue t, EventHandler handler)
        {
            this._handler = handler;
            this._tenue = t;
            InitializeComponent();
        }

        public void DefinirStatsHero(string stats, string nomHeros)
        {
            lblStat.Text = stats;
            lblNomHero.Text = nomHeros;
        }
        public void DefinirStatsArme(string stats, string nomArme)
        {
            lblStat.Text = stats;
            lblNomHero.Text = nomArme;
        }
        public void DefinirMiniature(Image miniature)
        {
            pbxImage.Image = miniature;
        }

        public void SupprimerBtnChoisir()
        {
            this.btnValider.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (_handler == null)
                return;
            
            _handler(sender, e);
        }

        public Heros RecupererHeros()
        {
            return this._heros;
        }
        public Arme RecupererArmes()
        {
            return this._arme;
        }
        public Tenue RecupererTenues()
        {
            return this._tenue;
        }

        //public void MiseAJour()
        //{
        //    // Rareté
        //    Color border_color = Color.White;
        //    switch (_objet.Rarete)
        //    {
        //        case RareteObjet.Commun:
        //            border_color = Color.Gray; break;
        //        case RareteObjet.PeuCommun:
        //            border_color = Color.LimeGreen; break;
        //        case RareteObjet.Rare:
        //            border_color = Color.DeepSkyBlue; break;
        //        case RareteObjet.TresRare:
        //            border_color = Color.Magenta; break;
        //        case RareteObjet.Legendaire:
        //            border_color = Color.Gold; break;
        //    }

        //    this.BackColor = border_color;
        //}
    }
}
