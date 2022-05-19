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
        /// <summary>
        /// Constructeur pour afficher la carte d'un héro
        /// </summary>
        /// <param name="h">l'héro à afficher</param>
        public CarteAffichage(Heros h)
        {
            this._heros = h;
            InitializeComponent();
        }
        /// <summary>
        /// Constructeur pour afficher la carte d'un héro
        /// </summary>
        /// <param name="h">l'héro à afficher</param>
        /// <param name="handler">Evenement lors d'un clic</param>
        public CarteAffichage(Heros h, EventHandler handler)
        {
            this._handler = handler;
            this._heros = h;
            InitializeComponent();
        }
        /// <summary>
        /// Constructeur pour afficher la carte d'une arme
        /// </summary>
        /// <param name="h">l'arme à afficher</param>
        public CarteAffichage(Arme a, EventHandler handler)
        {
            this._handler = handler;
            this._arme = a;
            InitializeComponent();
        }
        /// <summary>
        /// Constructeur pour afficher la carte d'une tenue
        /// </summary>
        /// <param name="h">la tenue à afficher</param>
        public CarteAffichage(Tenue t, EventHandler handler)
        {
            this._handler = handler;
            this._tenue = t;
            InitializeComponent();
        }
        /// <summary>
        /// Affiche les stats et le nom de l'héro
        /// </summary>
        /// <param name="stats">statistique à afficher</param>
        /// <param name="nomHeros">nom de l'héro</param>
        public void DefinirStatsHero(string stats, string nomHeros)
        {
            lblStat.Text = stats;
            lblNomHero.Text = nomHeros;
        }
        /// <summary>
        /// Affichge les stats et le nom de l'arme
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="nomArme"></param>
        public void DefinirStatsArme(string stats, string nomArme)
        {
            lblStat.Text = stats;
            lblNomHero.Text = nomArme;
        }
        /// <summary>
        /// Affichage l'image de l'héro
        /// </summary>
        /// <param name="miniature">image de l'héro</param>
        public void DefinirMiniature(Image miniature)
        {
            pbxImage.Image = miniature;
        }
        /// <summary>
        /// Supprime le bouton choisir pour un affichage sans action
        /// </summary>
        public void SupprimerBtnChoisir()
        {
            this.btnValider.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Désactive le bouton
            this.Enabled = false;
            if (_handler == null)
                return;
            
            _handler(sender, e);
        }
        /// <summary>
        /// Récupère l'héro
        /// </summary>
        /// <returns>L'héro</returns>
        public Heros RecupererHeros()
        {
            return this._heros;
        }
        /// <summary>
        /// Récupère l'arme
        /// </summary>
        /// <returns>L'arme</returns>
        public Arme RecupererArmes()
        {
            return this._arme;
        }
        /// <summary>
        /// Récupère la tenue
        /// </summary>
        /// <returns>La tenue</returns>
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
