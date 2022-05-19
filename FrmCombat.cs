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
    public partial class FrmCombat : Form
    {
        //Initialisation
       
        bool attaque = false;
        bool defense = false;
        bool mouvement = false;
        bool capaciteSpecial = false;

        string nomCompagnieJoueur;
        string nomCompagnieEnnemi;
        frmSalon frmSalon = new frmSalon();
        //combat
        Combat combat = new Combat();

        public FrmCombat()
        {
            InitializeComponent();
        }
        public void DefinirCompagnie()
        {
            combat.CompagnieJoueurInit(CompagnieStocker.compagnieActuelle);
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
                    if (combat.NbHeroRestantJoueur >= 1)
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
                    if (combat.NbHeroRestantEnnemi >= 1)
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
        /// <summary>
        /// Init de la fenetre
        /// /// </summary>
        private void CommencerAffichage()
        {
            //init élément graphique
            lblNiveauCampagne.Visible = true;
            lbl6.Visible = true;
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
            lbl3.Visible = true;
            lbl4.Visible = true;
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

            lblNiveauCampagne.Text = combat.CompagnieJoueur.NivCampagne.ToString();

            pbxPerso1.Image = combat.HeroPrincipalJoueur.ImageHero;
            pbxPerso2.Image = combat.CompagnieJoueur.Heros[1].ImageHero;
            pbxPerso3.Image = combat.CompagnieJoueur.Heros[2].ImageHero;

            //Joueur
            lblNomCompagnie.Text = nomCompagnieJoueur;
            lblViePerso.Text = combat.HeroPrincipalJoueur.NvVie.ToString();
            lblNomHero.Text = combat.HeroPrincipalJoueur.NomHeros;
            //Ennemi
            lblNomCompagnieEnnemi.Text = nomCompagnieEnnemi;
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
        /// <summary>
        /// Affichage des actions de l'ennemi et verification des héros
        /// </summary>
        private void TourEnnemiAffichage()
        {
            lbxAction.Items.Add(nomCompagnieEnnemi + " : " + combat.ActionsEnnemi[combat.NumActionEnnemi]);
            if (combat.ActionsEnnemi[combat.NumActionEnnemi] == "Mouvement")
            {
                ChangementHeroAffichage(false);
                ChangementVieEtNom(false);
            }
            else if (combat.ActionsEnnemi[combat.NumActionEnnemi] == "Capacite Speciale")
            {
                VerifNbCapaciteSpecialRestant(false);
            }
            else
            {
                ChangementVieEtNom(true);
            }
            VerifNbHeroAffichage(true);
            ActionEnnemi();

        }
        /// <summary>
        /// Verification lors de la mort d'un héro si il en reste et affichage gagné ou perdu
        /// </summary>
        /// <param name="joueur">joueur</param>
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
                    lbxAffichage.Items.Add("La compagnie " + nomCompagnieJoueur + " a été tuée, vous avez perdu");

                    string affichagePerdu = "Vous avez gagné " + combat.NbPoCombatPerduBase + " Po et " + combat.NbXpCombatPerduBase + " Xp.";
                    MessageBox.Show(affichagePerdu);
                    FinCombat();
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
                    lbxAffichage.Items.Add("La compagnie " + nomCompagnieEnnemi + "a été tuée, vous avez gagné");

                    string affichageGagne = "Vous avez gagné " + combat.NbPoCombatGagnerBase + " Po et " + combat.NbXpCombatGagneBase + " Xp.";
                    MessageBox.Show(affichageGagne);
                    FinCombat();
                }
            }
        }
        /// <summary>
        /// Combat terminé
        /// </summary>
        private void FinCombat()
        {
            combat.RecupVie();
            frmSalon.Show();
            this.Close();
        }
        /// <summary>
        /// Verification du nombre de capacite spéciale réstante
        /// </summary>
        /// <param name="joueur">action du joueur</param>
        private void VerifNbCapaciteSpecialRestant(bool joueur)
        {
            if (joueur)
            {
                if (combat.NbCapaciteSpecialJoueur < 1)
                {
                    btnCapaciteSpecial.Enabled = false;
                }
            }
            else
            {
                if (combat.NbCapaciteSpecialEnnemi < 1)
                {
                    combat.ActionsEnnemi.Remove("Capacite Speciale");
                }
            }
        }
        /// <summary>
        /// Changement de l'héro principal
        /// </summary>
        /// <param name="actionJoueur">action du joueur</param>
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
        }
        /// <summary>
        /// Si l'ennemi fait une action
        /// </summary>
        private void ActionEnnemi()
        {
            btnAttaque.Enabled = true;
            btnDefense.Enabled = true;
            if (combat.NbHeroRestantJoueur > 1)
            {
                btnChangement.Enabled = true;
            }
            if (combat.NbCapaciteSpecialJoueur >= 1)
            {
                btnCapaciteSpecial.Enabled = true;
            }

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
            ActionJoueur();
        }

        private void btnFinTour_Click(object sender, EventArgs e)
        {
            btnFinTour.Enabled = false;
            if (attaque)
            {
                combat.Attaque(combat.HeroPrincipalJoueur, combat.HeroPrincipalEnnemi);
                AttaqueAffichage(true);
                lbxAction.Items.Add(nomCompagnieJoueur + " : Attaque");
            }
            else if (defense)
            {
                combat.Defense(combat.HeroPrincipalJoueur);
                ChangementVieEtNom(true);
                lbxAction.Items.Add(nomCompagnieJoueur + " : Defense");
            }
            else if (mouvement)
            {
                combat.Mouvement(true);
                ChangementHeroAffichage(true);
                ChangementVieEtNom(true);
                lbxAction.Items.Add(nomCompagnieJoueur + " : Mouvement");
            }
            else if (capaciteSpecial)
            {
                combat.CapaciteSpecial(combat.HeroPrincipalJoueur, combat.HeroPrincipalEnnemi);
                ChangementVieEtNom(false);
                lbxAction.Items.Add(nomCompagnieJoueur + " : Capacité Spéciale");
                VerifNbCapaciteSpecialRestant(true);
            }
            ActionJoueur();
            capaciteSpecial = false;
            defense = false;
            attaque = false;
            mouvement = false;
            combat.TourEnnemi();
            TourEnnemiAffichage();
        }

        private void btnCapaciteSpecial_Click(object sender, EventArgs e)
        {
            capaciteSpecial = true;
            btnActionCliquer();
        }

        private void btnAttaque_Click(object sender, EventArgs e)
        {
            attaque = true;
            btnActionCliquer();
        }

        private void btnDefense_Click(object sender, EventArgs e)
        {
            defense = true;
            btnActionCliquer();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            DefinirCompagnie();
            combat.Commencer();
            CommencerAffichage();

            nomCompagnieEnnemi = combat.CompagnieEnnemi.NomCompagnie;
            nomCompagnieJoueur = combat.CompagnieJoueur.NomCompagnie;
        }

        private void btnChangement_Click(object sender, EventArgs e)
        {
            mouvement = true;
            btnActionCliquer();
        }
    }
}