using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace P_Heroes
{
    public partial class SelectionPerso : Form
    {
        Compagnie compagnie = new Compagnie();
        Arme armeChoisi1;
        Arme armeChoisi2;
        Heros heros1 = new Heros();
        Heros heros2 = new Heros();
        Heros heros3 = new Heros();
        Tenue tenueSelectionne;
        Heros heroSelectionne;
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
            heros1.Heros1(nomHero);
            tbxNomPerso1.Enabled = false;
            RefreshBtnOk();
            heroSelectionne = heros1;
            RefreshStats(heroSelectionne);
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso2.Text;
            heros2.Heros2(nomHero);
            tbxNomPerso2.Enabled = false;
            RefreshBtnOk();
            heroSelectionne = heros2;
            RefreshStats(heroSelectionne);

        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso3.Text;
            heros3.Heros3(nomHero);
            tbxNomPerso3.Enabled = false;
            RefreshBtnOk();
            heroSelectionne = heros3;
            RefreshStats(heroSelectionne);
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
            compagnie.AjoutHeros(heroSelectionne);
            if (compagnie.Heros.Count == 1)
            {
                pbxPerso2.Visible = true;
                btnOk1.Enabled = true;
            }
            else if (compagnie.Heros.Count == 2)
            {
                pbxPerso3.Visible = true;
                btnOk2.Enabled = true;
            }
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            compagnie.majNom(tbxNomCompagnie.Text);
        }

        private void majPbx(object sender, EventArgs e)
        {
            PictureBox pbxCliquer = ((PictureBox)sender);
            object tag = pbxCliquer.Tag;
            if (tag == null)
            {
                return;
            }
            if (pbxCliquer.Tag.ToString() == "tissu")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("tissu");
            }
            else if (pbxCliquer.Tag.ToString() == "cuir")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("cuir");
            }
            else if (pbxCliquer.Tag.ToString() == "metal")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("metal");
            }
            compagnie.SelectionArme(pbxCliquer.Tag.ToString());
            pbxCliquer.Visible = false;
            
            foreach (var arme in compagnie.DicoListeArmes)
            {
                if (arme.Key == pbxCliquer.Tag.ToString())
                {
                    
                    if(arme.Value.arme.NbMains == 2)
                    {
                        armeChoisi1 = arme.Value.arme;
                        armeChoisi2 = arme.Value.arme;
                    }
                    else
                    {
                        if (armeChoisi1 == null)
                        {
                            armeChoisi1 = arme.Value.arme;
                        }
                        else
                        {
                            armeChoisi2 = arme.Value.arme;
                        }
                        
                    }
                }
            }


            if (armeChoisi1 != null && armeChoisi2 != null && tenueSelectionne != null)
            {
                heroSelectionne = Extension.TraitementHeros(armeChoisi1, armeChoisi2, tenueSelectionne, heroSelectionne);
                RefreshStats(heroSelectionne);
                btnValider.Enabled = true;
            }
        }
        private void RefreshStats(Heros hero)
        {
            lblAgilite.Text = hero.Agilite.ToString();
            lblVie.Text = hero.NvVie.ToString();
            lblAtt.Text = hero.Attaque.ToString();
            if (hero.Arme1 == null)
            {
                lblMainD.Text = "libre";
            }
            else
            {
                lblMainD.Text = hero.Arme1.NomArme.ToString();
            }
            if (hero.Arme2 == null)
            {
                lblMainG.Text = "libre";
            }
            else
            {
                lblMainG.Text = hero.Arme2.NomArme.ToString();
            }
        }
        private void SelectionPerso_Load(object sender, EventArgs e)
        {
            compagnie.InitListeArmes();

        }
    }
}
