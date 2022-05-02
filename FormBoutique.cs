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
    public partial class FormBoutique : Form
    {
        public FormBoutique()
        {
            InitializeComponent();
            var temp = new ShopItem();
            temp.Location = new Point(0, 0);
            this.Controls.Add(temp);
            var temp2 = new ShopItem();
            temp2.Location = new Point(100, 0);
            this.Controls.Add(temp2);

            /*
             * this.lblNom.Location = new System.Drawing.Point(35, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(212, 77);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            */
        }
    }
}
