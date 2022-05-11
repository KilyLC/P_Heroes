/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Form sélection des héros
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;


namespace P_Heroes
{
    public partial class SelectionArmes : Form
    {
        //init
        Compagnie compagnie = null;
        Heros heros1;
        Heros heros2;
        Heros heros3;
        Heros heroSelectionne;

        List<Arme> listeArmes = new List<Arme>();
        List<Tenue> listeTenues = new List<Tenue>();

        P_Heros form;
        public SelectionArmes()
        {
            InitializeComponent();
        }

        public SelectionArmes(P_Heros form) : this()
        {
            this.form = form;
        }

        public SelectionArmes(P_Heros form, Compagnie compagnie) : this(form)
        {
            this.compagnie = compagnie;
            this.heros1 = compagnie.Heros[0];
            this.heros2 = compagnie.Heros[1];
            this.heros3 = compagnie.Heros[2];
            this.heroSelectionne = heros1;
        }

        private void SelectionPerso_Load(object sender, EventArgs e)
        {
            CreeTenue();
            CreeArme();
            ImageHero();
            AffichageCarteArmeTenue();
        }
        public void CreeTenue()
        {
            Tenue legere = new Tenue();
            legere.CreeTenue("legere", 10, 10, Properties.Resources.tissu);
            listeTenues.Add(legere);
            DicoValues values = new DicoValues(legere, false);
            compagnie.DicoListeTenues["legere"] = values;

            Tenue moyenne = new Tenue();
            moyenne.CreeTenue("moyenne", 20, 20, Properties.Resources.cuir);
            listeTenues.Add(moyenne);
            values = new DicoValues(moyenne, false);
            compagnie.DicoListeTenues["moyenne"] = values;

            Tenue lourde = new Tenue();
            lourde.CreeTenue("lourde", 30, 30 ,Properties.Resources.metal);
            listeTenues.Add(lourde);
            values = new DicoValues(lourde, false);
            compagnie.DicoListeTenues["lourde"] = values;
        }
        public void CreeArme()
        {
            Arme hache = new Arme();
            hache.CreeArme(100, 25, 40, "hache", Properties.Resources.hache, 2);
            listeArmes.Add(hache);
            DicoValues values = new DicoValues(hache, false);
            compagnie.DicoListeArmes["hache"] = values;

            Arme lance = new Arme();
            lance.CreeArme(100, 10, 20, "lance", Properties.Resources.lance, 1);
            listeArmes.Add(lance);
            values = new DicoValues(lance, false);
            compagnie.DicoListeArmes["lance"] = values;

            Arme epee = new Arme();
            epee.CreeArme(100, 10, 20, "epee", Properties.Resources.epee, 1);
            listeArmes.Add(epee);
            values = new DicoValues(epee, false);
            compagnie.DicoListeArmes["epee"] = values;

            Arme arc = new Arme();
            arc.CreeArme(100, 25, 40, "arc", Properties.Resources.arc, 2);
            listeArmes.Add(arc);
            values = new DicoValues(arc, false);
            compagnie.DicoListeArmes["arc"] = values;

            Arme dague = new Arme();
            dague.CreeArme(100, 10, 20, "dague", Properties.Resources.dague, 1);
            listeArmes.Add(dague);
            values = new DicoValues(dague, false);
            compagnie.DicoListeArmes["dague"] = values;

            Arme bouclier = new Arme();
            bouclier.CreeArme(100, 10, 20, "bouclier", Properties.Resources.bouclier, 1);
            listeArmes.Add(bouclier);
            values = new DicoValues(bouclier, false);
            compagnie.DicoListeArmes["bouclier"] = values;
        }
        public void ImageHero()
        {
            for (int i = 1; i <= compagnie.Heros.Count; i++)
            {
                Image image = compagnie.Heros[i - 1].ImageHero;
                if (i == 1)
                {
                    pbxPerso1.Image = image;
                }
                else if (i == 2)
                {
                    pbxPerso2.Image = image;
                }
                else
                {
                    pbxPerso3.Image = image;
                }
            }
        }
        private void pbxPerso1_Paint(object sender, PaintEventArgs e)
        {
            if (compagnie.Heros.Count == 0)
                ControlPaint.DrawBorder(e.Graphics, pbxPerso1.ClientRectangle,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid
                );
            else
                ControlPaint.DrawBorder(e.Graphics, pbxPerso1.ClientRectangle,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid
                );
        }

        private void pbxPerso2_Paint(object sender, PaintEventArgs e)
        {
            if (compagnie.Heros.Count == 1)
                ControlPaint.DrawBorder(e.Graphics, pbxPerso2.ClientRectangle,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid
                );
            else
                ControlPaint.DrawBorder(e.Graphics, pbxPerso2.ClientRectangle,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid
                );
        }

        private void pbxPerso3_Paint(object sender, PaintEventArgs e)
        {
            if (compagnie.Heros.Count == 2)
                ControlPaint.DrawBorder(e.Graphics, pbxPerso3.ClientRectangle,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid,
                    Color.Red, 2, ButtonBorderStyle.Solid
                );
            else
                ControlPaint.DrawBorder(e.Graphics, pbxPerso3.ClientRectangle,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid,
                    this.BackColor, 2, ButtonBorderStyle.Solid
                );
        }

        private void btnOk1_Click(object sender, EventArgs e)
        {
            heros1.TraitementHeros(heros1.Arme1, heros1.Arme2, heros1.Tenue, heros1);
            btnOkClick(heros2, 1);
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            heros2.TraitementHeros(heros2.Arme1, heros2.Arme2, heros2.Tenue, heros2);
            btnOkClick(heros3, 2);
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            heros3.TraitementHeros(heros3.Arme1, heros3.Arme2, heros3.Tenue, heros3);
            btnOkClick(heros3, 3);
        }
       
        /// <summary>
        /// Rafraichi les stats
        /// </summary>
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
        
        private void btnOkClick(Heros hero, int numHero)
        {
            //héro 1
            if (numHero == 1)
            {
                btnOk1.Enabled = false;
                btnOk2.Enabled = true;
            }
            //héro 2
            else if (numHero == 2)
            {
                btnOk2.Enabled = false;
                btnOk3.Enabled = true;
            }
            else
            {
                btnOk3.Enabled = false;
                btnValider.Enabled = true;
            }
            heroSelectionne = hero;
            RefreshStats(heroSelectionne);
        }
        private void ClicArmes(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Arme a = ((PersoSelection)sender.Parent.Parent).RecupererArmes();

            if (heroSelectionne.Arme1 == null)
            {
                if (a.NbMains == 2)
                {
                    heroSelectionne.Arme1 = a;
                    heroSelectionne.Arme2 = a;
                }
                else
                {
                    heroSelectionne.Arme1 = a;
                }
            }
            else
            {
                heroSelectionne.Arme2 = a;
            }
            RefreshStats(heroSelectionne);
        }
        private void ClicTenues(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Tenue t = ((PersoSelection)sender.Parent.Parent).RecupererTenues();

            heroSelectionne.Tenue = t;
        }

        public void AffichageCarteArmeTenue()
        {
            int padx = 6;
            int pady = 6;
            int x = padx;
            int y = pady;
            int counterArme = 0;

            foreach (Arme a in listeArmes)
            {
                string stats = "";
                PersoSelection control = new PersoSelection(a, ClicArmes);
                control.DefinirMiniature(a.Image);
                stats = "Attaque : " + a.NvAttaque + Environment.NewLine + "Durabilité : " + a.Durabilite + Environment.NewLine + "Mains occupées : " + a.NbMains;
                control.DefinirStatsArme(stats, a.NomArme);
                control.Location = new Point(x, y);
                pnlAffichageArmes.Controls.Add(control);

                counterArme += 1;
                if (counterArme % 3 != 0)
                {
                    x += control.Size.Width + padx;
                }
                else
                {
                    x = padx;
                    y += control.Size.Height + pady;
                }
            }
            pady = 6;
            y = pady;
            foreach (Tenue t in listeTenues)
            {
                string stats = "";
                PersoSelection control = new PersoSelection(t, ClicTenues);
                control.DefinirMiniature(t.ImageTenue);
                stats = "Defense : " + t.NvDefense + Environment.NewLine + "Poids : " + t.Poids;
                control.DefinirStatsArme(stats, t.NomTenue);
                control.Location = new Point(0, y);
                pnlAffichageTenues.Controls.Add(control);
                
                y += control.Size.Height + pady;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            compagnie.Heros[0] = heros1;
            compagnie.Heros[1] = heros2;
            compagnie.Heros[2] = heros3;
            form.DefinirCompagnie(compagnie);
            this.Close();
        }
    }
}
