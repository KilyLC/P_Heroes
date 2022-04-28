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

namespace P_Heroes
{
    public partial class P_Heros : Form
    {
        System.Media.SoundPlayer player;
        public P_Heros()
        {
            InitializeComponent();
        }

        public void DefinirCompagnie(Compagnie compagnie)
        {
            this.compagnie = compagnie;
        }
        //Initialisation
        Compagnie compagnie;
        int numHeroPrincipal = 1;
        private void P_Heros_Load(object sender, EventArgs e)
        {
            pbrVieEnnemi.Value = 100;
            EcranChargement ecranChargement = new EcranChargement(this);
            ecranChargement.Show(this);
            playSound();
        }
        private void playSound()
        {
            player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.MusicSeigneurAnneaux;
            player.PlayLooping();

        }

        private void btnChangement_Click(object sender, EventArgs e)
        {
            numHeroPrincipal += 1;
            if (numHeroPrincipal > 3)
            {
                numHeroPrincipal = 1;
            }
            if (numHeroPrincipal == 1)
            {
                pbxPerso1.Image = compagnie.Heros[0].ImageArme;
                pbxPerso2.Image = compagnie.Heros[1].ImageArme;
                pbxPerso3.Image = compagnie.Heros[2].ImageArme;
            }
            else if (numHeroPrincipal == 2)
            {
                pbxPerso1.Image = compagnie.Heros[1].ImageArme;
                pbxPerso2.Image = compagnie.Heros[2].ImageArme;
                pbxPerso3.Image = compagnie.Heros[0].ImageArme;
            }
            else
            {
                pbxPerso1.Image = compagnie.Heros[2].ImageArme;
                pbxPerso2.Image = compagnie.Heros[0].ImageArme;
                pbxPerso3.Image = compagnie.Heros[1].ImageArme;
            }
        }

        private void ChangementVie(Heros hero)
        {
            pbrViePerso.Value = hero.NvVie;
            lblViePerso.Text = pbrViePerso.Value.ToString();
        }


    }
}
