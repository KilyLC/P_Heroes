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
        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);


        public Accueil(P_Heros p_Heros)
        {
            InitializeComponent();
          
            lblNbVolume.Text = hsbVolume.Value.ToString();

            int newVolume = ((ushort.MaxValue / 5) * hsbVolume.Value / 10);
            uint newVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16));
            waveOutSetVolume(IntPtr.Zero, newVolumeAllChannels);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            EcranChargement ecranChargment = new EcranChargement();
            ecranChargment.Show();
        }



        private void hsbVolume_Scroll(object sender, ScrollEventArgs e)
        {
            lblNbVolume.Text = hsbVolume.Value.ToString();

            int newVolume = ((ushort.MaxValue / 5) * hsbVolume.Value / 10);
            uint newVolumeAllChannels = (((uint)newVolume & 0x0000ffff) | ((uint)newVolume << 16));
            waveOutSetVolume(IntPtr.Zero, newVolumeAllChannels);
        }
    }
}
