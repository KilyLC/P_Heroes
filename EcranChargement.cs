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
        public EcranChargement()
        {
            InitializeComponent();
        }
        
        private void tmrChargement_Tick(object sender, EventArgs e)
        {
            
            while (pbrChargement.Value < pbrChargement.Maximum)
            {
                Refresh();
                pbrChargement.Value += 1;

            }

            tmrChargement.Stop();

            SelectionPerso selectionPerso = new SelectionPerso();
            selectionPerso.Show();

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
