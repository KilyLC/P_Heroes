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

        bool attaque = false;
        bool defense = false;
        bool mouvement = false;

        //combat
        Combat combat = new Combat();

        public P_Heros()
        {
            InitializeComponent();
        }

        public void DefinirCompagnie(Compagnie compagnie)
        {
            combat.CompagnieJoueurInit(compagnie);
        }
      
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
            mouvement = true;
            btnActionCliquer();
        }
        /// <summary>
        /// Change la vie et le nom selon l'héro
        /// </summary>
        private void ChangementVieEtNom(bool joueur)
        {
            if (joueur)
            {
                //Maj nom hero
                lblNomHero.Text = combat.HeroPrincipalJoueur.NomHeros;
                //Maj progressbar vie
                if (combat.HeroPrincipalJoueur.NvVie > pbrViePerso.Maximum)
                {
                    pbrViePerso.Value = pbrViePerso.Maximum;
                }
                else if (combat.HeroPrincipalJoueur.NvVie <= 0)
                {
                    MortHeroAffichage(true);
                    combat.HeroMort(combat.HeroPrincipalJoueur);
                    VerifNbHeroAffichage(true);
                    if (combat.NbHeroRestantJoueur > 1)
                    {
                        ChangementHeroAffichage(true);
                        ChangementVieEtNom(true);
                    }
                }
                else
                {
                    pbrViePerso.Value = combat.HeroPrincipalJoueur.NvVie;
                }
                //Maj label vie
                lblViePerso.Text = combat.HeroPrincipalJoueur.NvVie.ToString();
            }
            //Ennemi
            else
            {
                //Maj nom hero 
                lblNomEnnemi.Text = combat.HeroPrincipalEnnemi.NomHeros;
                //Maj progressbar vie
                if (combat.HeroPrincipalEnnemi.NvVie > pbrVieEnnemi.Maximum)
                {
                    pbrVieEnnemi.Value = pbrVieEnnemi.Maximum;
                }
                else if (combat.HeroPrincipalEnnemi.NvVie <= 0)
                {   
                    MortHeroAffichage(false);
                    combat.HeroMort(combat.HeroPrincipalEnnemi);
                    VerifNbHeroAffichage(false);
                    if (combat.NbHeroRestantEnnemi > 1)
                    {
                        ChangementHeroAffichage(false);
                        ChangementVieEtNom(false);
                    }
                }
                else
                {
                    pbrVieEnnemi.Value = combat.HeroPrincipalEnnemi.NvVie;
                }
                //Maj label vie
                lblVieEnnemi.Text = combat.HeroPrincipalEnnemi.NvVie.ToString();

            }
        }
        private void btnCommencer_Click(object sender, EventArgs e)
        {
            combat.Commencer();
            CommencerAffichage();
        }
        /// <summary>
        /// Init de la fenetre
        /// /// </summary>
        private void CommencerAffichage()
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
            lbl5.Visible = true;
            lbxAffichage.Visible = true;
            lblVieEnnemi.Visible = true;
            lbl1.Visible = true;
            lbxAction.Visible = true;
            btnAttaque.Visible = true;
            btnFinTour.Visible = true;
            btnCapaciteSpecial.Visible = true;
            lblNomHero.Visible = true;
            btnChangement.Visible = true;
            btnDefense.Visible = true;
            pbxEnnemi1.Visible = true;
            pbxEnnemi2.Visible = true;
            pbxEnnemi3.Visible = true;
            lblNomEnnemi.Visible = true;
            label3.Visible = true;
            lblNomCompagnieEnnemi.Visible = true;

            //Joueur
            lblNomCompagnie.Text = combat.CompagnieJoueur.NomCompagnie;
            lblViePerso.Text = combat.HeroPrincipalJoueur.NvVie.ToString();
            lblNomHero.Text = combat.HeroPrincipalJoueur.NomHeros;
            //Ennemi
            lblNomCompagnieEnnemi.Text = combat.CompagnieEnnemi.NomCompagnie;
            lblVieEnnemi.Text = combat.HeroPrincipalEnnemi.NvVie.ToString();
            lblNomEnnemi.Text = combat.HeroPrincipalEnnemi.NomHeros;
        }
        /// <summary>
        /// En cas d'attaque du joueur 
        /// </summary>
        private void AttaqueAffichage(bool joueur)
        {
            if (joueur)
            {
                ChangementVieEtNom(false);
            }
            else
            {
                ChangementVieEtNom(true); ;
            }
           
        }

        private void btnAttaque_Click(object sender, EventArgs e)
        {
            attaque = true;
            btnActionCliquer();
        }
        private void TourEnnemiAffichage()
        {
            lbxAction.Items.Add(combat.CompagnieEnnemi.NomCompagnie + " : " + combat.ActionsEnnemi[combat.NumActionEnnemi]);
            if (combat.ActionsEnnemi[combat.NumActionEnnemi] == "Mouvement")
            {
                ChangementHeroAffichage(false);
                ChangementVieEtNom(false);
            }
            else
            {
                ChangementVieEtNom(true);
            }
            VerifNbHeroAffichage(true);
            ActionEnnemi();
            
        }
        private void btnDefense_Click(object sender, EventArgs e)
        {
            defense = true;
            btnActionCliquer();
        }

        private void VerifNbHeroAffichage(bool joueur)
        {
            if (joueur)
            {
                if (combat.NbHeroRestantJoueur == 1)
                {
                    btnChangement.Enabled = false;
                }
                else if (combat.Perdu())
                {
                    lbxAffichage.Items.Add("La compagnie " + combat.CompagnieJoueur.NomCompagnie + " a été tuée, vous avez perdu");
                }
            }
            else
            {
                if (combat.NbHeroRestantEnnemi == 1)
                {
                    combat.ActionsEnnemi.Remove("Mouvement");
                }
                else if (combat.Gagne())
                {
                    lbxAffichage.Items.Add("La compagnie " +  combat.CompagnieEnnemi.NomCompagnie + "a été tuée, vous avez gagné");
                }
            }
        }

        private void ChangementHeroAffichage(bool actionJoueur)
        {
            if (actionJoueur)
            {
                combat.HeroPrincipalJoueur = combat.CompagnieJoueur.Heros[combat.NumHeroPrincipalJoueur - 1];
                pbxPerso1.Image = combat.HeroPrincipalJoueur.ImageHero;
                ChangementVieEtNom(true);
                //Hero 1
                if (combat.NumHeroPrincipalJoueur == 1)
                {
                    pbxPerso2.Image = combat.CompagnieJoueur.Heros[1].ImageHero;
                    pbxPerso3.Image = combat.CompagnieJoueur.Heros[2].ImageHero;
                }
                //Hero 2
                else if (combat.NumHeroPrincipalJoueur == 2)
                {
                    pbxPerso2.Image = combat.CompagnieJoueur.Heros[2].ImageHero;
                    pbxPerso3.Image = combat.CompagnieJoueur.Heros[0].ImageHero;
                }
                //Hero 3
                else
                {
                    pbxPerso2.Image = combat.CompagnieJoueur.Heros[0].ImageHero;
                    pbxPerso3.Image = combat.CompagnieJoueur.Heros[1].ImageHero;
                }
            }
            else
            {
                combat.HeroPrincipalEnnemi = combat.CompagnieEnnemi.Heros[combat.NumHeroPrincipalEnnemi - 1];
                pbxEnnemi1.Image = combat.HeroPrincipalEnnemi.ImageHero;
                ChangementVieEtNom(false);
                //Hero 1
                if (combat.NumHeroPrincipalEnnemi == 1)
                {
                    pbxEnnemi2.Image = combat.CompagnieEnnemi.Heros[1].ImageHero;
                    pbxEnnemi3.Image = combat.CompagnieEnnemi.Heros[2].ImageHero;
                }
                //Hero 2
                else if (combat.NumHeroPrincipalEnnemi == 2)
                {
                    pbxEnnemi2.Image = combat.CompagnieEnnemi.Heros[2].ImageHero;
                    pbxEnnemi3.Image = combat.CompagnieEnnemi.Heros[0].ImageHero;
                }
                //Hero 3
                else
                {
                    pbxEnnemi2.Image = combat.CompagnieEnnemi.Heros[0].ImageHero;
                    pbxEnnemi3.Image = combat.CompagnieEnnemi.Heros[1].ImageHero;
                }
            }
        }

        /// <summary>
        /// Si le joueur fait une action
        /// </summary>
        private void ActionJoueur()
        {
            btnAttaque.Enabled = false;
            btnDefense.Enabled = false;
            btnChangement.Enabled = false;
            btnCapaciteSpecial.Enabled = false;
            btnFinTour.Enabled = false;
        }
        /// <summary>
        /// Si l'ennemi fait une action
        /// </summary>
        private void ActionEnnemi()
        {
            btnAttaque.Enabled = true;
            btnDefense.Enabled = true;
            btnChangement.Enabled = true;
            btnCapaciteSpecial.Enabled = true;
        }
        /// <summary>
        /// Si un héro meurt
        /// </summary>
        private void MortHeroAffichage(bool joueur)
        {
            if (joueur)
            {
                lblViePerso.Text = "0";
                pbrViePerso.Value = 0;
                lbxAffichage.Items.Add("Vous avez perdu l'héro : " + combat.HeroPrincipalJoueur.NomHeros);
            }
            else
            {
                lblVieEnnemi.Text = "0";
                pbrVieEnnemi.Value = 0;
                lbxAffichage.Items.Add("Vous avez tué l'héro : " + combat.HeroPrincipalEnnemi.NomHeros);
            }
            
        }
        private void btnActionCliquer()
        {
            btnFinTour.Enabled = true;
        }

        private void btnFinTour_Click(object sender, EventArgs e)
        {
            if (attaque)
            {
                combat.Attaque(true);
                AttaqueAffichage(true);
                lbxAction.Items.Add(combat.CompagnieJoueur.NomCompagnie + " : Attaque");
            }
            else if (defense)
            {
                combat.Defense(true);
                ChangementVieEtNom(true);
                lbxAction.Items.Add(combat.CompagnieJoueur.NomCompagnie + " : Defense");
            }
            else if (mouvement)
            {
                combat.Mouvement(true);
                ChangementHeroAffichage(true);
                ChangementVieEtNom(true);
                lbxAction.Items.Add(combat.CompagnieJoueur.NomCompagnie + " : Mouvement");
            }
            ActionJoueur();
            defense = false;
            attaque = false;
            mouvement = false;
            combat.TourEnnemi();
            TourEnnemiAffichage();
        }
    }
}
