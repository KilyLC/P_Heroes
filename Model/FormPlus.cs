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
    public partial class FormPlus : Form
    {
        public FormPlus()
        {
            InitializeComponent();
        }

        public FormPlus(string texte) : this()
        {
            DefinirTexte(texte);
        }

        public void DefinirTexte(string texte)
        {
            this.lblMain.Text = texte;
        }
    }
}
