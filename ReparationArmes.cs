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
        //affichage pbx position
        int padx = 6;
        int x = 6;
        int counterArme = 0;

        bool validationArgent;
        
        Reparer reparer;
        public ReparationArmes()
        {
            InitializeComponent();
        }

        private void ReparationArmes_Load(object sender, EventArgs e)
        {
            reparer = new Reparer();
            RefreshAffichage();
            
        }
        /// <summary>
        /// Arme cliquer
        /// </summary>
        /// <param name="_sender">object cliquer</param>
        /// <param name="e">evenement</param>
        private void ClicArmes(object _sender, EventArgs e)
        {
            btnReset.Enabled = true;

            Button sender = (Button)_sender;

            Arme a = ((CarteAffichage)sender.Parent.Parent).RecupererArmes();

            PbxArmeSelectionne(a);

            reparer.AjoutListeArmeSelectionne(a);
            validationArgent = reparer.VerifArgent();
            lblPrixTotal.Text = reparer.PrixTotal.ToString();
            if (validationArgent)
            {
                btnReparer.Enabled = true;
            }
            else
            {
                btnReparer.Enabled = false;
            }
        }
        /// <summary>
        /// Créer automatiquement des pictubox pour les armes sélectionnés
        /// </summary>
        /// <param name="arme"></param>
        private void PbxArmeSelectionne(Arme arme)
        {
            int y = 15;
            PictureBox pbx = new PictureBox();
            pbx.Image = arme.Image;
            pbx.SizeMode = PictureBoxSizeMode.Zoom;
            pbx.Size = new Size(100, 100);
            pbx.Location = new Point(x, y);

            gbxArmeSelect.Controls.Add(pbx);
           
            counterArme += 1;
            if (counterArme % 5 != 0)
            {
                x += pbx.Width + padx;
            }
        }
        
        
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
                if (a.Durabilite == reparer.DurabiliteMax)
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
            padx = 6;
            x = 6;
            btnReparer.Enabled = false;
            btnReset.Enabled = false;
            //Vide le panel
            pnlAffichageArmes.Controls.Clear();
            gbxArmeSelect.Controls.Clear();          
            lblPrixTotal.Text = reparer.PrixTotal.ToString();
            AffichageCartesArmes();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reparer.Reset();
            RefreshAffichage();
        }

        private void btnReparer_Click(object sender, EventArgs e)
        {
            reparer.ReparerArmes();
            Refresh();
            frmSalon frmSalon = new frmSalon();
            frmSalon.Show();
            this.Close();
        }

        
    }
}
