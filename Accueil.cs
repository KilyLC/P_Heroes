using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Heroes
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {

        }

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        private void hsbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            int newVolume = ((ushort.MaxValue / 5) * hsbVolume.Value / 10);
            uint newVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16));
            waveOutSetVolume(IntPtr.Zero,  newVolumeAllChannels);
        }
    }
}
