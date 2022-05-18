using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes
{
    public partial class frmSalon : Form
    {
        int numCompagnie;
        P_Heros form;
        public frmSalon()
        {
            InitializeComponent();
        }
        public frmSalon(P_Heros form) : this()
        {
            this.form = form;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            //page accueil
            P_Heros accueil = new P_Heros();
            accueil.Show();
        }

        private void btnBoutique_Click(object sender, EventArgs e)
        {
            //boutique
            FormBoutique formBoutique = new FormBoutique();
            formBoutique.Show();
        }

        private void btnCreerCompagnie_Click(object sender, EventArgs e)
        {
            //page selection heros
            SelectionHeros selectionHeros = new SelectionHeros();
            selectionHeros.Show();
            this.Close();
        }

        private void frmSalon_Load(object sender, EventArgs e)
        {
            lblNumCompagnie.Text = "1" + " / " + CompagnieStocker.NB_COMPAGNIE_MAX;
            RefreshCompagnie();
            if (CompagnieStocker.compagniesJoueur.Count > 1)
            {
                btnChoixCompagnie.Enabled = true;
            }

            // Si le nombre de compagnie depasse le max
            if(CompagnieStocker.compagniesJoueur.Count >= CompagnieStocker.NB_COMPAGNIE_MAX)
            {
                btnCreerCompagnie.Enabled = false;
            }
            else
            {
                btnCreerCompagnie.Enabled = true;
            }
            
        }
        public void AffichageCarteHero()
        {
            int padx = 6;
            int pady = 6;
            int x = padx;
            int y = pady;
            int counter = 0;

            foreach (Heros h in CompagnieStocker.compagnieActuelle.Heros)
            {
                string stats = "";
                CarteAffichage control = new CarteAffichage(h);
                control.DefinirMiniature(h.ImageHero);
                stats = "Vie : " + h.NvVie + Environment.NewLine + "Agilité : " + h.Agilite + Environment.NewLine + "Attaque : " + h.Attaque + Environment.NewLine + "Capacité spéciale : " + h.CapaciteSpecial;
                control.DefinirStatsHero(stats, h.NomHeros);
                control.SupprimerBtnChoisir(); 
                control.Location = new Point(x, y);
                pnlAffichageHeros.Controls.Add(control);

                counter += 1;
                if (counter % 3 != 0)
                {
                    x += control.Size.Width + padx;
                }
                else
                {
                    x = padx;
                    y += control.Size.Height + pady;
                }
            }
        }
        private void RefreshCompagnie()
        {
            if (CompagnieStocker.compagnieActuelle != null)
            {
                lblXpCompagnie.Text = CompagnieStocker.compagnieActuelle.Xp.ToString();
                lblPoCompagnie.Text = CompagnieStocker.compagnieActuelle.Po.ToString();
                pgbXp.Value = CompagnieStocker.compagnieActuelle.Xp;
                pgbXp.Maximum = CompagnieStocker.compagnieActuelle.NbXpPalierNiveau;
                lblNiveauCompagnie.Text = CompagnieStocker.compagnieActuelle.Niveau.ToString();
                lblXpMax.Text = CompagnieStocker.compagnieActuelle.NbXpPalierNiveau.ToString();
                lblNomCompagnie.Text = CompagnieStocker.compagnieActuelle.NomCompagnie;
                //Hero 1
                pbxHero1Tenue.Image = CompagnieStocker.compagnieActuelle.Heros[0].Tenue.ImageTenue;
                pbxHero1Arme1.Image = CompagnieStocker.compagnieActuelle.Heros[0].Arme1.Image;
                if (CompagnieStocker.compagnieActuelle.Heros[0].Arme1 != CompagnieStocker.compagnieActuelle.Heros[0].Arme2)
                {
                    pbxHero1Arme2.Image = CompagnieStocker.compagnieActuelle.Heros[0].Arme2.Image;
                }
                //Hero 2
                pbxHero2Tenue.Image = CompagnieStocker.compagnieActuelle.Heros[1].Tenue.ImageTenue;
                pbxHero2Arme1.Image = CompagnieStocker.compagnieActuelle.Heros[1].Arme1.Image;
                if (CompagnieStocker.compagnieActuelle.Heros[1].Arme1 != CompagnieStocker.compagnieActuelle.Heros[1].Arme2)
                {
                    pbxHero2Arme2.Image = CompagnieStocker.compagnieActuelle.Heros[1].Arme2.Image;
                }

                //Hero 3
                pbxHero3Tenue.Image = CompagnieStocker.compagnieActuelle.Heros[2].Tenue.ImageTenue;
                pbxHero3Arme1.Image = CompagnieStocker.compagnieActuelle.Heros[2].Arme1.Image;
                if (CompagnieStocker.compagnieActuelle.Heros[2].Arme1 != CompagnieStocker.compagnieActuelle.Heros[2].Arme2)
                {
                    pbxHero3Arme2.Image = CompagnieStocker.compagnieActuelle.Heros[2].Arme2.Image;
                }

                AffichageCarteHero();
            }
        }

        private void btnCampagne_Click(object sender, EventArgs e)
        {
            FrmCombat frmCombat = new FrmCombat();
            frmCombat.Show();
            this.Close();
        }

        private void btnChoixCompagnie_Click(object sender, EventArgs e)
        {
            pnlAffichageHeros.Controls.Clear();
            numCompagnie++;
            if (numCompagnie > CompagnieStocker.compagniesJoueur.Count - 1)
            {
                numCompagnie = 0;
            }
            int numCompagnieAfficher = numCompagnie + 1;

            lblNumCompagnie.Text = numCompagnieAfficher + " / " + CompagnieStocker.NB_COMPAGNIE_MAX;
            CompagnieStocker.compagnieActuelle = CompagnieStocker.compagniesJoueur[numCompagnie];
            RefreshCompagnie();
        }
    }
}
