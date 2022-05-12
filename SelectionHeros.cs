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
    public partial class SelectionHeros : Form
    {
        Compagnie compagnie = new Compagnie();
        List<Heros> listHeros = new List<Heros>();

        private P_Heros _form;
        public SelectionHeros()
        {
            InitializeComponent();
            CreeHeros();
            Reset();
        }

        public SelectionHeros(P_Heros form) : this()
        {
            this._form = form;
        }

        PersoSelection persoSelection = new PersoSelection();

        public void CreeHeros()
        {
            Heros heros = new Heros();
            heros.CreeHero(1000, 40, 70, "aragorn", Properties.Resources.Aragorn, true, compagnie, "regeneration");
            listHeros.Add(heros);
            Heros heros2 = new Heros();
            heros2.CreeHero(1000, 70, 40, "Legolas", Properties.Resources.Legolas, true, compagnie, "defense");
            listHeros.Add(heros2);
            Heros heros3 = new Heros();
            heros3.CreeHero(1000, 30, 80, "Gimli", Properties.Resources.Gimli, true, compagnie, "attaque");
            listHeros.Add(heros3);
            Heros heros4 = new Heros();
            heros4.CreeHero(1000, 40, 50, "Frodon", Properties.Resources.Frodon, true, compagnie, "attaque");
            listHeros.Add(heros4);
            Heros heros5 = new Heros();
            heros5.CreeHero(1000, 70, 50, "Elrond", Properties.Resources.elrond, true, compagnie, "defense");
            listHeros.Add(heros5);
        }
        public void AffichageCarteHero()
        {
            int padx = 6;
            int pady = 6;
            int x = padx;
            int y = pady;
            int counter = 0;

            foreach (Heros h in listHeros)
            {
                string stats = "";
                PersoSelection control = new PersoSelection(h, ClicHeros);
                control.DefinirMiniature(h.ImageHero);
                stats = "Vie : " + h.NvVie + Environment.NewLine + "Agilité : " + h.Agilite + Environment.NewLine + "Attaque : " + h.Attaque;
                control.DefinirStatsHero(stats, h.NomHeros);
                control.Location = new Point(x, y);
                pnlAffichageHero.Controls.Add(control);
               
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
        private void ClicHeros(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Heros h = (Heros)((PersoSelection)sender.Parent.Parent).RecupererHeros();
            //hero temporaire pour stocker les valeurs par défault
            Heros temp = new Heros();
            temp.NvVie = h.NvVie;
            temp.Agilite = h.Agilite;
            temp.Attaque = h.Attaque;
            //ajout vrai hero a la liste
            compagnie.AjoutHeros(h);
            //ajout hero temporaire a la liste d'héro de base
            compagnie.HerosBase.Add(temp);

            if (compagnie.Heros.Count == 1)
            {
                pbxHero1.Image = h.ImageHero;
                btnReset.Enabled = true;
            }
            else if (compagnie.Heros.Count == 2)
            {
                pbxHero2.Image = h.ImageHero;
            }
            else
            {
                pbxHero3.Image = h.ImageHero;
                pnlAffichageHero.Enabled = false;
                ValiderHeros();
            }
        }
        
        private void tbxNomCampagnie_TextChanged(object sender, EventArgs e)
        {
            ValiderHeros();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pbxHero1.Image = null;
            pbxHero2.Image = null;
            pbxHero3.Image = null;
            pnlAffichageHero.Enabled = true;
            compagnie.Heros.Clear();
            Reset();
        }
        public void Reset()
        {
            btnValider.Enabled = false;
            btnReset.Enabled = false;
            pnlAffichageHero.Controls.Clear();
            AffichageCarteHero();
        }
        public void ValiderHeros()
        {
            if (tbxNomCampagnie.Text != "" && compagnie.Heros.Count == 3)
            {
                btnValider.Enabled = true;
            }
            else
            {
                btnValider.Enabled = false;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            compagnie.majNom(tbxNomCampagnie.Text);
            
            SelectionArmes selectionArmes = new SelectionArmes(_form, compagnie);
            selectionArmes.Show();
            this.Close();
        }
    }
}
