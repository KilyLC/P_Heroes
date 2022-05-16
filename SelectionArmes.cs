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
        Compagnie compagnie = CompagnieStocker.compagnieActuelle;
        Heros heros1;
        Heros heros2;
        Heros heros3;
        Heros heroSelectionne;

        List<Arme> listeArmes = new List<Arme>();
        List<Tenue> listeTenues = new List<Tenue>();

        int numHeroSelectionne = 1;

        FrmCombat form;
        public SelectionArmes()
        {
            InitializeComponent();
        }

        public SelectionArmes(FrmCombat form) : this()
        {
            this.form = form;

            //Récupere la compagnie
            //this.compagnie = compagnie;
            //Assigne les héros
            this.heros1 = compagnie.Heros[0];
            this.heros2 = compagnie.Heros[1];
            this.heros3 = compagnie.Heros[2];

            this.heroSelectionne = heros1;
        }

        private void SelectionPerso_Load(object sender, EventArgs e)
        {
            CreeArme();
            CreeTenue();
            ImageHero();
            AffichageCarteArmeTenue();
            RefreshStats();
        }
        /// <summary>
         /// Crée les tenues
         /// </summary>
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
        /// <summary>
        /// Crée les armes
        /// </summary>
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
        /// <summary>
        /// Affichage des images des héros sélectionné
        /// </summary>
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
            ItemRefreshImage(heros1);
            btnOkClick(heros2, 1);
            numHeroSelectionne = 2;
            pnlAffichageArmes.Enabled = true;
            pnlAffichageTenues.Enabled = true;
        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            ItemRefreshImage(heros2);
            numHeroSelectionne = 3;
            btnOkClick(heros3, 2);
            pnlAffichageArmes.Enabled = true;
            pnlAffichageTenues.Enabled = true;
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            ItemRefreshImage(heros3);
            btnOkClick(heros3, 3);
        }
        /// <summary>
        /// Affichage de l'image des items séléctionné sous l'héro concerné
        /// </summary>
        /// <param name="hero"></param>
        private void ItemRefreshImage(Heros hero)
        {
            //Hero 1
            if (numHeroSelectionne == 1)
            {
                if (hero.Arme1 == null && hero.Arme2 == null && hero.Tenue == null)
                {
                    pbxArme2Hero1.Image = null;
                    pbxTenueHero1.Image = null;
                    pbxArme1Hero1.Image = null;
                    return;
                }
                if (hero.Arme1.NbMains == 2)
                {
                    pbxArme2Hero1.Visible = false;
                }
                pbxArme1Hero1.Image = hero.Arme1.Image;
                pbxArme2Hero1.Image = hero.Arme2.Image;
                pbxTenueHero1.Image = hero.Tenue.ImageTenue;
            }
            //Hero 2
            else if (numHeroSelectionne == 2)
            {
                if (hero.Arme1 == null && hero.Arme2 == null && hero.Tenue == null)
                {
                    pbxArme2Hero2.Image = null;
                    pbxTenueHero2.Image = null;
                    pbxArme1Hero2.Image = null;
                    return;
                }
                if (hero.Arme1.NbMains == 2)
                {
                    pbxArme2Hero2.Visible = false;
                }
                pbxArme1Hero2.Image = hero.Arme1.Image;
                pbxArme2Hero2.Image = hero.Arme2.Image;
                pbxTenueHero2.Image = hero.Tenue.ImageTenue;
            }
            //Hero 3
            else
            {
                if (hero.Arme1 == null && hero.Arme2 == null && hero.Tenue == null)
                {
                    pbxArme2Hero3.Image = null;
                    pbxTenueHero3.Image = null;
                    pbxArme1Hero3.Image = null;
                    return;
                }
                if (hero.Arme1.NbMains == 2)
                {
                    pbxArme2Hero3.Visible = false;
                }
                pbxArme1Hero3.Image = hero.Arme1.Image;
                pbxArme2Hero3.Image = hero.Arme2.Image;
                pbxTenueHero3.Image = hero.Tenue.ImageTenue;
            }
        }
        /// <summary>
        /// Rafraichi les stats
        /// </summary>
        private void RefreshStats()
        {
            lblAgilite.Text = heroSelectionne.Agilite.ToString();
            lblVie.Text = heroSelectionne.NvVie.ToString();
            lblAtt.Text = heroSelectionne.Attaque.ToString();
            
            if (heroSelectionne.Arme1 == null)
            {
                lblMainD.Text = "libre";
            }
            else
            {
                lblMainD.Text = heroSelectionne.Arme1.NomArme.ToString();
            }
            if (heroSelectionne.Arme2 == null)
            {
                lblMainG.Text = "libre";
            }
            else
            {
                lblMainG.Text = heroSelectionne.Arme2.NomArme.ToString();
            }
        }
        /// <summary>
        /// Refresh bouton ok lors d'un clic
        /// </summary>
        /// <param name="hero">Hero concerne</param>
        /// <param name="numHero">numéro de l'héro</param>
        private void btnOkClick(Heros hero, int numHero)
        {
            //héro 1
            if (numHero == 1)
            {
                btnOk1.Enabled = false;
            }
            //héro 2
            else if (numHero == 2)
            {
                btnOk2.Enabled = false;
            }
            else
            {
                btnOk3.Enabled = false;
                btnValider.Enabled = true;
            }
            heroSelectionne = hero;
            RefreshStats();
        }
        private void ClicArmes(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Arme a = ((CarteAffichage)sender.Parent.Parent).RecupererArmes();
            //Mains 1
            if (heroSelectionne.Arme1 == null)
            {
                //Arme 2 mains
                if (a.NbMains == 2)
                {
                    heroSelectionne.Arme1 = a;
                    heroSelectionne.Arme2 = a;
                    pnlAffichageArmes.Enabled = false;
                }
                else
                {
                    //Arme une main
                    heroSelectionne.Arme1 = a;
                }
            }
            else if (heroSelectionne.Arme2 == null && a.NbMains == 1)
            {
                //2ème arme
                heroSelectionne.Arme2 = a;
                pnlAffichageArmes.Enabled = false;
            }
            TraitementStatsClic();
            RefreshStats();
        }
        private void TraitementStatsClic()
        {
            if (heroSelectionne.Arme1 != null && heroSelectionne.Arme2 != null && heroSelectionne.Tenue != null)
            {
                ItemRefreshImage(heroSelectionne);
                if (numHeroSelectionne == 1)
                {
                    btnOk1.Enabled = true;
                    //Change les stats de l'héro
                    heros1.TraitementStats(heroSelectionne.Arme1, heroSelectionne.Arme2, heroSelectionne.Tenue, heros1);
                    RefreshStats();
                }
                else if (numHeroSelectionne == 2)
                {
                    btnOk2.Enabled = true;
                    heros2.TraitementStats(heroSelectionne.Arme1, heroSelectionne.Arme2, heroSelectionne.Tenue, heros2);
                    RefreshStats();
                }
                else
                {
                    btnOk3.Enabled = true;
                    heros3.TraitementStats(heroSelectionne.Arme1, heroSelectionne.Arme2, heroSelectionne.Tenue, heros3);
                    RefreshStats();
                }
            }
        }
        private void ClicTenues(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Tenue t = ((CarteAffichage)sender.Parent.Parent).RecupererTenues();
            //Attribut la tenue à l'héro
            heroSelectionne.Tenue = t;

            if (heroSelectionne.Tenue != null)
            {
                pnlAffichageTenues.Enabled = false;
            }
            TraitementStatsClic();
        }
        /// <summary>
        /// Affichage des armes et des tenues
        /// </summary>
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
                CarteAffichage control = new CarteAffichage(a, ClicArmes);
                //image armes
                control.DefinirMiniature(a.Image);
                //Affcihage stats
                stats = "Attaque : " + a.NvAttaque + Environment.NewLine + "Durabilité : " + a.Durabilite + Environment.NewLine + "Mains occupées : " + a.NbMains;
                control.DefinirStatsArme(stats, a.NomArme);
                //Position
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
                CarteAffichage control = new CarteAffichage(t, ClicTenues);
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
            //Valide les héros
            compagnie.Heros[0] = heros1;
            compagnie.Heros[1] = heros2;
            compagnie.Heros[2] = heros3;

            frmSalon frmSalon = new frmSalon();
            frmSalon.Show();
            this.Close();
        }

        private void btnResetHero_Click(object sender, EventArgs e)
        {
            ResetHeros();
            AffichageCarteArmeTenue();
            RefreshStats();
            ItemRefreshImage(heroSelectionne);
        }
        /// <summary>
        /// Reset les armes et tenues
        /// </summary>
        private void ResetHeros()
        {
            //Remets les valeurs par défaults aux héros
            //hero 1
            compagnie.Heros[0].Agilite = compagnie.HerosBase[0].Agilite;
            compagnie.Heros[0].NvVie = compagnie.HerosBase[0].NvVie;
            compagnie.Heros[0].Attaque = compagnie.HerosBase[0].Attaque;
            //hero 2
            compagnie.Heros[1].Agilite = compagnie.HerosBase[1].Agilite;
            compagnie.Heros[1].NvVie = compagnie.HerosBase[1].NvVie;
            compagnie.Heros[1].Attaque = compagnie.HerosBase[1].Attaque;
            //hero 3
            compagnie.Heros[2].Agilite = compagnie.HerosBase[2].Agilite;
            compagnie.Heros[2].NvVie = compagnie.HerosBase[2].NvVie;
            compagnie.Heros[2].Attaque = compagnie.HerosBase[2].Attaque;

            heroSelectionne = compagnie.Heros[0];
            heros1 = heroSelectionne;
            heros2 = compagnie.Heros[1];
            heros3 = compagnie.Heros[2];
            //Refresh des panels d'affichage d'armes et tenues
            pnlAffichageArmes.Controls.Clear();
            pnlAffichageTenues.Controls.Clear();
            pnlAffichageTenues.Enabled = true;
            pnlAffichageArmes.Enabled = true;

            //Vide les armes et tenues
            heros1.Arme1 = null;
            heros1.Arme2 = null;
            heros1.Tenue = null;
            heros2.Arme1 = null;
            heros2.Arme2 = null;
            heros2.Tenue = null;
            heros3.Arme1 = null;
            heros3.Arme2 = null;
            heros3.Tenue = null;
            //Desactive les boutons des héros
            btnOk1.Enabled = false;
            btnOk2.Enabled = false;
            btnOk3.Enabled = false;
            //Refresh des pbx image item sélectionné
            pbxArme1Hero1.Image = null;
            pbxArme2Hero1.Image = null;
            pbxTenueHero1.Image = null;
            pbxArme1Hero2.Image = null;
            pbxTenueHero2.Image = null;
            pbxArme2Hero2.Image = null;
            pbxArme1Hero3.Image = null;
            pbxArme2Hero3.Image = null;
            pbxTenueHero3.Image = null;

            numHeroSelectionne = 1;
        }
    }
}
