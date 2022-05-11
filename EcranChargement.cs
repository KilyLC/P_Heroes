/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Form écran de chargement
 */
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
    public partial class EcranChargement : Form
    {
        P_Heros form;

        public EcranChargement()
        {
            InitializeComponent();
        }

        public EcranChargement(P_Heros form) : this()
        {
            this.form = form;
        }

        private void tmrChargement_Tick(object sender, EventArgs e)
        {
            
            while (pbrChargement.Value < pbrChargement.Maximum)
            {
                Refresh();
                pbrChargement.Value += 1;

            }
            tmrChargement.Stop();
            //SelectionArmes selectionArmes = new SelectionArmes(form);
            //selectionArmes.Show();
            SelectionHeros selectionHeros = new SelectionHeros();
            selectionHeros.Show();
            this.Close();
        }

        private void EcranChargement_Load(object sender, EventArgs e)
        {
            tmrChargement.Start();
            pbrChargement.Value = 0;
        }

        private void pbrChargement_Click(object sender, EventArgs e)
        {  

        }
    }
}
