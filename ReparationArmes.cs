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
    public partial class ReparationArmes : Form
    {
        const int DURABILITE_MAX = 100;
        List<Arme> armeSelect = new List<Arme>();
        int prixTotal;
        //affichage pbx position
        int padx = 6;
        int pady = 6;
        int x = 6;
        int y = 6;
        int counterArme = 0;
        public ReparationArmes()
        {
            InitializeComponent();
        }

        private void ReparationArmes_Load(object sender, EventArgs e)
        {
            RefreshAffichage();
        }
        /// <summary>
        /// Arme cliquer
        /// </summary>
        /// <param name="_sender">object cliquer</param>
        /// <param name="e">evenement</param>
        private void ClicArmes(object _sender, EventArgs e)
        {
            Button sender = (Button)_sender;

            Arme a = ((CarteAffichage)sender.Parent.Parent).RecupererArmes();

            PbxArmeSelectionne(a);
        }
        /// <summary>
        /// Créer automatiquement des pictubox pour les armes sélectionnés
        /// </summary>
        /// <param name="arme"></param>
        private void PbxArmeSelectionne(Arme arme)
        {
            PictureBox pbx = new PictureBox();
            pbx.Image = arme.Image;
            pbx.SizeMode = PictureBoxSizeMode.Zoom;
            pbx.Size = new Size(100, 100);
            pbx.Location = new Point(x, y);

            gbxArmeSelect.Controls.Add(pbx);

            counterArme += 1;
            if (counterArme % 3 != 0)
            {
                x += gbxArmeSelect.Size.Width + padx;
            }
            else
            {
                x = padx;
                y += gbxArmeSelect.Size.Height + pady;
            }
        }
        /// <summary>
        /// Ajoute l'arme à la liste des armes sélectionnés
        /// </summary>
        /// <param name="a"></param>
        private void AjoutListeArmeSelectionne(Arme a)
        {
            armeSelect.Add(a);
        }
        /*/// <summary>
        /// Calcul du prix total des armes sélectionnés
        /// </summary>
        private void CalculPrix()
        {
            foreach (Arme a in armeSelect)
            {

            }
        } */
        /// <summary>
        /// Affichage des cartes armes
        /// </summary>
        private void AffichageCartesArmes()
        {
            int padx = 6;
            int pady = 6;
            int x = padx;
            int y = pady;
            int counterArme = 0;

            foreach (Arme a in CompagnieStocker.compagnieActuelle.Inventaire.Armes)
            {
                a.Durabilite = 30;
                if (a.Durabilite == DURABILITE_MAX)
                {
                    continue;
                }
                else
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
            }
        }
        /// <summary>
        /// Reset de la page
        /// </summary>
        private void RefreshAffichage()
        {
            prixTotal = 0;
            btnReparer.Enabled = false;
            btnReset.Enabled = false;
            pnlAffichageArmes.Controls.Clear();
            armeSelect.Clear();
            gbxArmeSelect.Controls.Clear();          
            lblPrixTotal.Text = prixTotal.ToString();
            AffichageCartesArmes();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            RefreshAffichage();
        }

        private void btnReparer_Click(object sender, EventArgs e)
        {

        }
    }
}
