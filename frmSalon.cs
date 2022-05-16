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
        }

        private void RefreshCompagnie()
        {
            if (CompagnieStocker.compagnieActuelle != null)
            {
                pbxHero1.Image = CompagnieStocker.compagnieActuelle.Heros[0].ImageHero;
                pbxHero2.Image = CompagnieStocker.compagnieActuelle.Heros[1].ImageHero;
                pbxHero3.Image = CompagnieStocker.compagnieActuelle.Heros[2].ImageHero;
                lblNomCompagnie.Text = CompagnieStocker.compagnieActuelle.NomCompagnie;
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
