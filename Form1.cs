/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Form principal (combat)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace P_Heroes
{
    public partial class P_Heros : Form
    {
        System.Media.SoundPlayer player;
        int vieEnnemi = 100;

        public P_Heros()
        {
            InitializeComponent();
        }

        public void DefinirCompagnie(Compagnie compagnie)
        {
            this.compagnie = compagnie;
        }
        //Initialisation
        Compagnie compagnie;
        int numHeroPrincipal = 1;
        private void P_Heros_Load(object sender, EventArgs e)
        {
            pbrVieEnnemi.Value = 100;
            EcranChargement ecranChargement = new EcranChargement(this);
            ecranChargement.Show(this);
            playSound();
        }
        /// <summary>
        /// Lance la musique
        /// </summary>
        private void playSound()
        {
            player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.MusicSeigneurAnneaux;
            player.PlayLooping();

        }

        private void btnChangement_Click(object sender, EventArgs e)
        {
            numHeroPrincipal += 1;
            if (numHeroPrincipal > 3)
            {
                numHeroPrincipal = 1;
            }
            pbxPerso1.Image = compagnie.Heros[numHeroPrincipal - 1].ImageArme;
            ChangementVieEtNom(compagnie.Heros[numHeroPrincipal - 1]);
            //Hero 1
            if (numHeroPrincipal == 1)
            {
                pbxPerso2.Image = compagnie.Heros[1].ImageArme;
                pbxPerso3.Image = compagnie.Heros[2].ImageArme;
            }
            //Hero 2
            else if (numHeroPrincipal == 2)
            {
                pbxPerso2.Image = compagnie.Heros[2].ImageArme;
                pbxPerso3.Image = compagnie.Heros[0].ImageArme;
            }
            //Hero 3
            else
            {
                pbxPerso2.Image = compagnie.Heros[0].ImageArme;
                pbxPerso3.Image = compagnie.Heros[1].ImageArme;
            }
        }
        /// <summary>
        /// Change la vie et le nom selon l'héro
        /// </summary>
        private void ChangementVieEtNom(Heros hero)
        {
            //Maj nom hero
            lblNomHero.Text = hero.NomHeros;
            //Maj progressbar vie
            if (hero.NvVie > pbrViePerso.Maximum)
            {
                pbrViePerso.Value = pbrViePerso.Maximum;
            }
            else
            {
                pbrViePerso.Value = hero.NvVie;
            }
            //Maj label vie
            lblViePerso.Text = hero.NvVie.ToString();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            Commencer();
        }
        /// <summary>
        /// Init de la fenetre
        /// /// </summary>
        private void Commencer()
        {
            //init élément graphique
            btnCommencer.Enabled = false;
            btnCommencer.Visible = false;
            pbrVieEnnemi.Visible = true;
            pbrViePerso.Visible = true;
            pbxPerso1.Visible = true;
            pbxPerso2.Visible = true;
            pbxPerso3.Visible = true;
            lblNomCompagnie.Visible = true;
            lblViePerso.Visible = true;
            lblVieEnnemi.Visible = true;
            lbl1.Visible = true;
            pbxEnnemie.Visible = true;
            btnAttaque.Visible = true;
            lblNomHero.Visible = true;
            btnChangement.Visible = true;
            btnDefense.Visible = true;
            //init nom compagnie, hero et la vie de l'héro principal
            lblNomCompagnie.Text = compagnie.NomCompagnie;
            lblViePerso.Text = compagnie.Heros[0].NvVie.ToString();
            lblNomHero.Text = compagnie.Heros[0].NomHeros;
        }

        private void Attaque(Heros hero)
        {
            vieEnnemi -= hero.Attaque;
            if (vieEnnemi <= 0)
            {
                lblVieEnnemi.Text = "0";
                pbrVieEnnemi.Value = pbrVieEnnemi.Minimum;
                MessageBox.Show("Bravo vous avez gagné");
                
            }
            else
            {
                pbrVieEnnemi.Value = vieEnnemi;
                lblVieEnnemi.Text = vieEnnemi.ToString();
            }
        }

        private void btnAttaque_Click(object sender, EventArgs e)
        {
            Attaque(compagnie.Heros[numHeroPrincipal - 1]);
        }
    }
}
