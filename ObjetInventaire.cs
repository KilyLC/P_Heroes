using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes
{
    public partial class ObjetInventaire : UserControl
    {
        private EventHandler _handler = null;
        public int Idx = -1;

        public ObjetInventaire()
        {
            InitializeComponent();
        }

        public ObjetInventaire(ObjetBoutique o) : this()
        {
            AfficherMiniature(o.Miniature);
            AfficherRarete(o.Rarete);
        }

        public void DefinirEventHandler(EventHandler handler)
        {
            _handler = handler;
        }

        public void AfficherRarete(RareteObjet rarete)
        {
            Color border_color = Color.White;
            switch (rarete)
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

            pnlRarete.BackColor = border_color;
        }

        public void AfficherMiniature(Image miniature)
        {
            pbxMiniature.Image = miniature;
        }

        // Passer l'event à la form
        private void pbxMiniature_Click(object sender, EventArgs e)
        {
            ObjetInventaire_Click(sender, e);
        }

        // Passer l'event à la form
        private void pnlRarete_Click(object sender, EventArgs e)
        {
            ObjetInventaire_Click(sender, e);
        }

        private void ObjetInventaire_Click(object _sender, EventArgs e)
        {
            if (_handler == null)
                return;

            object sender;
            if (!(_sender is ObjetInventaire))
            {
                sender = ((Control)_sender).Parent;
            }
            else
            {
                sender = _sender;
            }    
            
            _handler(sender, e);
        }
    }
}
