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
        //Initialisation
        System.Media.SoundPlayer player;

        Compagnie compagnie;
        int numHeroPrincipal = 1;
        int vieEnnemi = 100;
        const int attaque = 30;
        Heros heroPrincipal;
        Random rnd = new Random();
        int valeurRandom = 3;
        bool defenseEnnemi = false;
        List<string> actionEnnemi = new List<string>();
        List<Heros> listeHeros = new List<Heros>();

        public P_Heros()
        {
            InitializeComponent();
        }

        public void DefinirCompagnie(Compagnie compagnie)
        {
            this.compagnie = compagnie;
            listeHeros = compagnie.Heros;
        }
      
        private void P_Heros_Load(object sender, EventArgs e)
        {
            pbrVieEnnemi.Value = 100;
            EcranChargement ecranChargement = new EcranChargement(this);
            ecranChargement.Show(this);
            playSound();
            actionEnnemi.Add("Defense");
            actionEnnemi.Add("Attaque");
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
            lbxAction.Items.Add(compagnie.NomCompagnie + " : Changement");
            ActionJoueur();
            numHeroPrincipal += 1;
            numHeroVerif();
            heroPrincipal = compagnie.Heros[numHeroPrincipal - 1];
            if (heroPrincipal.NvVie <= 0)
            {
                numHeroPrincipal += 1;
                numHeroVerif();
                heroPrincipal = compagnie.Heros[numHeroPrincipal - 1];
            }
            pbxPerso1.Image = heroPrincipal.ImageArme;
            ChangementVieEtNom(heroPrincipal);
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
            TourEnnemiDefault(heroPrincipal, false);
        }
        private void numHeroVerif()
        {
            if (numHeroPrincipal > 3)
            {
                numHeroPrincipal = 1;
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
            else if (hero.NvVie <= 0)
            {
                MessageBox.Show("Vous avez perdu l'héro : " + hero.NomHeros);   
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
            lbxAction.Visible = true;
            btnAttaque.Visible = true;
            lblNomHero.Visible = true;
            btnChangement.Visible = true;
            btnDefense.Visible = true;
            //init nom compagnie, hero et la vie de l'héro principal
            heroPrincipal = compagnie.Heros[numHeroPrincipal - 1];
            lblNomCompagnie.Text = compagnie.NomCompagnie;
            lblViePerso.Text = heroPrincipal.NvVie.ToString();
            lblNomHero.Text = heroPrincipal.NomHeros;
        }

        private void Attaque(Heros hero)
        {
            lbxAction.Items.Add(compagnie.NomCompagnie + " : Attaque");
            if (defenseEnnemi)
            {
                vieEnnemi -= Convert.ToInt32(hero.Attaque / 2);
            }
            else
            {
                vieEnnemi -= hero.Attaque;
            }
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
            Attaque(heroPrincipal);
            ActionJoueur();
            TourEnnemiDefault(heroPrincipal, false);
            
        }
        private void TourEnnemiDefault(Heros hero, bool defenseHero)
        {
            defenseEnnemi = false;
            valeurRandom = rnd.Next(0, 2);
            if (actionEnnemi[valeurRandom] == "Defense")
            {
                defenseEnnemi = true;
            }
            else
            {
                if (defenseHero)
                {
                    hero.NvVie -= Convert.ToInt32(attaque / 2);
                }
                else
                {
                    hero.NvVie -= attaque;
                }
            }
            lbxAction.Items.Add("Ennemi : " + actionEnnemi[valeurRandom]);
            ChangementVieEtNom(hero);
            ActionEnnemi();
        }

        private void btnDefense_Click(object sender, EventArgs e)
        {
            ActionJoueur();
            lbxAction.Items.Add(compagnie.NomCompagnie + " : Defense");
            TourEnnemiDefault(heroPrincipal, true);
        }
        private void ActionJoueur()
        {
            btnAttaque.Enabled = false;
            btnDefense.Enabled = false;
            btnChangement.Enabled = false;
        }
        private void ActionEnnemi()
        {
            btnAttaque.Enabled = true;
            btnDefense.Enabled = true;
            btnChangement.Enabled = true;
        }

        private void MortHero()
        {
            listeHeros.Remove(heroPrincipal);
            btnAttaque.Enabled = false;
            btnDefense.Enabled = false;
        }
    }
}
