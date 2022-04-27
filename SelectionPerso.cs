using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace P_Heroes
{
    public partial class SelectionPerso : Form
    {
        public SelectionPerso()
        {
            InitializeComponent();
        }

        private void pbxPerso1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbxPerso1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void pbxPerso2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbxPerso2.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void pbxPerso3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pbxPerso3.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void pbxTissu_Click(object sender, EventArgs e)
        {
            Tenue tenue = new Tenue("tissu");
        }

        private void pbxCuir_Click(object sender, EventArgs e)
        {
            Tenue tenue = new Tenue("cuir");
        }

        private void pbxMetal_Click(object sender, EventArgs e)
        {
            Tenue tenue = new Tenue("metal");
        }

        public void RefreshBtnOk()
        {
            pbxArc.Visible = true;
            pbxBouclier.Visible = true;
            pbxCuir.Visible = true;
            pbxDague.Visible = true;
            pbxEpee.Visible = true;
            pbxHache.Visible = true;
            pbxLance.Visible = true;
            pbxMetal.Visible = true;
            pbxTissu.Visible = true;
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso1.Text;
            Heros heros1 = new Heros();
            heros1.Heros1(nomHero);
            tbxNomPerso1.Enabled = false;
            RefreshBtnOk();
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso2.Text;
            Heros heros2 = new Heros();
            heros2.Heros2(nomHero);
            tbxNomPerso2.Enabled = false;
            RefreshBtnOk();

        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso3.Text;
            Heros heros3 = new Heros();
            heros3.Heros3(nomHero);
            tbxNomPerso3.Enabled = false;
            RefreshBtnOk();
            
        }

        private void tbxNomPerso1_TextChanged(object sender, EventArgs e)
        {
            if (tbxNomPerso1.Text != "")
            {
                btnOk1.Enabled = true;
            }
            else
            {
                btnOk1.Enabled = false;
            }
        }

        private void tbxNomPerso2_TextChanged(object sender, EventArgs e)
        {
            if (tbxNomPerso2.Text != "")
            {
                btnOk2.Enabled = true;
            }
            else
            {
                btnOk2.Enabled = false;
            }
        }

        private void tbxNomPerso3_TextChanged(object sender, EventArgs e)
        {
            if (tbxNomPerso3.Text != "")
            {
                btnOk3.Enabled = true;
            }
            else
            {
                btnOk3.Enabled = false;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Arme arme = new Arme();
            Tenue tenue = new Tenue("metal");
            Heros hero1 = Extension.TraitementHeros(arme, tenue);
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Compagnie compagnie = new Compagnie(tbxNomCompagnie.Text);
        }
    }
}
