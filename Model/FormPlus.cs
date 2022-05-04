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

        public FormPlus(Objet o) : this()
        {
            MiseAJour(o);
        }

        public void MiseAJour(Objet o)
        {
            this.lblMain.Text = o.Description;
            this.Text = o.Nom;
        }
    }
}
