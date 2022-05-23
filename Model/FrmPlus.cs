using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes.Model
{
    public partial class FrmPlus : Form
    {
        public FrmPlus()
        {
            InitializeComponent();
        }
         
        public FrmPlus(Objet o) : this()
        {
            MiseAJour(o);
        }

        public void MiseAJour(Objet o)
        {
            this.pbxMiniature.Image = o.Miniature;
            this.Text = o.Nom;

            // Couleur de fond selon rareté
            Color border_color = Color.White;
            switch (o.Rarete)
            {
                case RareteObjet.Commun:
                    border_color = Color.Gray; break;
                case RareteObjet.PeuCommun:
                    border_color = Color.LimeGreen; break;
                case RareteObjet.Rare:
                    border_color = Color.DeepSkyBlue; break;
                case RareteObjet.TresRare:
                    border_color = Color.Magenta; break;
                case RareteObjet.Legendaire:
                    border_color = Color.Gold; break;
            }

            this.BackColor = border_color;
            
            // Couleur texte selon fond
            uint argb = (uint)border_color.ToArgb();
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if (argb > 0x00000FFF)
                        c.ForeColor = Color.Black;
                    else
                        c.ForeColor = Color.White;
                }
            }

            // Définir texte
            this.lblDescription.Text = o.Description;
            this.lblStats.Text = o.StatistiquesEnTexte();
        }
    }
}
