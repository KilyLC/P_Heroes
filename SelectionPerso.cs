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
        private void SelectionPerso_Load(object sender, EventArgs e)
        {
            compagnie.InitListeArmes();

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

        private void btnOk1_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso1.Text;
            btnOkClick(heros1, 1, nomHero);
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso2.Text;
            btnOkClick(heros2, 2, nomHero);
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            string nomHero = tbxNomPerso3.Text;
            btnOkClick(heros3, 3, nomHero);
            
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
            //ajoute un héro à la compagnie
            compagnie.AjoutHeros(heroSelectionne);
            //héro 2
            if (compagnie.Heros.Count == 1)
            {   
                btnOk1.Enabled = false;
                pbxPerso2.Visible = true;
                btnOk2.Visible = true;
                tbxNomPerso2.Visible = true;
            }
            //héro 3
            else if (compagnie.Heros.Count == 2)
            {
                btnOk2.Enabled = false;
                pbxPerso3.Visible = true;
                btnOk3.Visible = true;
                tbxNomPerso3.Visible = true;
            }
            btnValider.Enabled = false;
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

            pbxCliquer.Visible = false;

            //Traitement de la tenue
            if (pbxCliquer.Tag.ToString() == "tissu")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("tissu");
                RefreshTenue(tenueSelectionne);
            }
            else if (pbxCliquer.Tag.ToString() == "cuir")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("cuir");
                RefreshTenue(tenueSelectionne);
            }
            else if (pbxCliquer.Tag.ToString() == "metal")
            {
                tenueSelectionne = new Tenue();
                tenueSelectionne = tenueSelectionne.majTenue("metal");
                RefreshTenue(tenueSelectionne);
            }

            //Traitement de l'arme
            compagnie.SelectionArme(pbxCliquer.Tag.ToString());
            
            foreach (var arme in compagnie.DicoListeArmes)
            {
                if (arme.Key == pbxCliquer.Tag.ToString())
                {
                    
                    if(arme.Value.arme.NbMains == 2)
                    {
                        //arme 2 mains
                        armeChoisi1 = arme.Value.arme;
                        armeChoisi2 = arme.Value.arme;
                    }
                    else
                    {
                        //arme 1 main
                        if (armeChoisi1 == null)
                        {
                            armeChoisi1 = arme.Value.arme;
                        }
                        else
                        {
                            armeChoisi2 = arme.Value.arme;
                        }
                    }

                    RefreshArme(pbxCliquer.Tag.ToString());
                }
            }
            if (armeChoisi1 != null && armeChoisi2 != null && tenueSelectionne != null)
            {
                //maj de l'héros
                heroSelectionne = Extension.TraitementHeros(armeChoisi1, armeChoisi2, tenueSelectionne, heroSelectionne);
                RefreshStats(heroSelectionne);
                btnValider.Enabled = true;
                armeChoisi1 = null;
                armeChoisi2 = null;
                tenueSelectionne = null;
            }
        }

        //Rafraichis les stats
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
        //rafraichi au clique d'un nouveau hero
        private void RefreshBtnOk()
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
        //Refresh toutes les armes selon l'arme sélectionné
        private void RefreshArme(string tagPbx)
        {
            pbxArc.Visible = false;
            pbxHache.Visible = false;
            if (armeChoisi2 != null)
            {
                pbxBouclier.Visible = false;
                pbxLance.Visible = false;
                pbxDague.Visible = false;
                pbxEpee.Visible = false;
            }
            if (tagPbx == "lance")
            {
                pbxLance.Enabled = false;
            }
            else if (tagPbx == "bouclier")
            {
                pbxBouclier.Enabled = false;
            }
            else if (tagPbx == "epee")
            {
                pbxEpee.Enabled = false;
            }
            else if (tagPbx == "dague")
            {
                pbxDague.Enabled = false;
            }
            else if (tagPbx == "hache")
            {
                pbxHache.Enabled = false;
                pbxArc.Visible = false;
                pbxBouclier.Visible = false;
                pbxLance.Visible = false;
                pbxDague.Visible = false;
                pbxEpee.Visible = false;
            }
            else if(tagPbx == "arc") 
            {
                pbxArc.Enabled = false;
                pbxBouclier.Visible = false;
                pbxLance.Visible = false;
                pbxDague.Visible = false;
                pbxEpee.Visible = false;
                pbxHache.Visible = false;
            }
        }
        //Rafraichi les tenues
        private void RefreshTenue(Tenue tenue)
        {
            if (tenue.NomTenue == "tissu")
            {
                pbxTissu.Enabled = false;
                pbxCuir.Visible = false;
                pbxMetal.Visible = false;
            }
            else if (tenue.NomTenue == "cuir")
            {
                pbxCuir.Enabled = false;
                pbxTissu.Visible = false;
                pbxMetal.Visible = false;
            }
            else if (tenue.NomTenue == "metal")
            {
                pbxMetal.Enabled = false;
                pbxTissu.Visible = false;
                pbxCuir.Visible = false;
            }
        }
        
        private void btnOkClick(Heros hero, int numHero, string nomHero)
        {
            if (numHero == 1)
            {
                hero.Heros1(nomHero);
                tbxNomPerso1.Enabled = false;
                btnOk1.Enabled = false;
            }
            else if (numHero == 2)
            {
                hero.Heros2(nomHero);
                tbxNomPerso2.Enabled = false;
                btnOk2.Enabled = false;
            }
            else
            {
                hero.Heros3(nomHero);
                tbxNomPerso3.Enabled = false;
                btnOk3.Enabled = false;
            }
            RefreshBtnOk();
            heroSelectionne = hero;
            RefreshStats(heroSelectionne);
        }

    }
}
