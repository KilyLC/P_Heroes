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
            Accueil accueil = new Accueil();
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
            SelectionHeros selectionHeros = new SelectionHeros(this.form);
            selectionHeros.Show();
            this.Close();
        }

        private void frmSalon_Load(object sender, EventArgs e)
        {
            if (CompagnieActuelle.compagnie != null)
            {
                pbxHero1.Image = CompagnieActuelle.compagnie.Heros[0].ImageHero;
                pbxHero2.Image = CompagnieActuelle.compagnie.Heros[1].ImageHero;
                pbxHero3.Image = CompagnieActuelle.compagnie.Heros[2].ImageHero;
            }
            
        }
    }
}
