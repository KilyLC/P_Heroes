/*
 * Billegas Lucas, Crausaz Neal 
 * Projet : Jeu en c#
 * Fichier : Form principal (combat)
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
using System.IO;
using System.Runtime.InteropServices;

namespace P_Heroes
{
    public partial class P_Heros : Form
    {
        System.Media.SoundPlayer player;

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);


        public P_Heros()
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
        /// <summary>
        /// Lance la musique
        /// </summary>
        private void playSound()
        {
            player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.MusicSeigneurAnneaux;
            player.PlayLooping();
        }
        private void P_Heros_Load(object sender, EventArgs e)
        {
            playSound();
        }
    }
}