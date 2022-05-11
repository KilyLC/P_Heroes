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
    public partial class PersoSelection : UserControl
    {
        private EventHandler _handler = null;
        private Heros _heros;
        public PersoSelection()
        {
            InitializeComponent();
        }

        public PersoSelection(Heros h, EventHandler handler)
        {
            this._handler = handler;
            this._heros = h;
            InitializeComponent();
        }

        public void DefinirStats(string stats, string nomHeros)
        {
            lblStat.Text = stats;
            lblNomHero.Text = nomHeros;
        }
        public void DefinirMiniature(Image miniature)
        {
            pbxHeros.Image = miniature;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (_handler == null)
                return;
            
            _handler(sender, e);
        }

        public Heros RecupererHeros()
        {
            return this._heros;
        }
    }
}
