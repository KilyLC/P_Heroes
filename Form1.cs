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

        //Initialisation
        string choixHero = "";
        Image imagePrincipal;
        Image imageSecondaire;
        private void P_Heros_Load(object sender, EventArgs e)
        {
            pbrVie.Value = 100;
            EcranChargement ecranChargement = new EcranChargement();
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
        }
        public void RecupererImage(Image image)
        {
            if (choixHero == "Perso1")
            {
                pbxPerso1.Image = Properties.Resources.Hero1;
                btnChangement.Enabled = false;
                lblChangement.Visible = false;
                pbxPerso1.Image = imagePrincipal;
            }
            else if (choixHero == "Perso2")
            {
                pbxPerso1.Image = Properties.Resources.Hero2;
                btnChangement.Enabled = false;
                lblChangement.Visible = false;
                pbxPerso2.Image = imagePrincipal;
            }
            else if (choixHero == "Perso3")
            {
                pbxPerso1.Image = Properties.Resources.Hero3;
                btnChangement.Enabled = false;
                lblChangement.Visible = false;
                pbxPerso3.Image = imagePrincipal;
            }
        }


        private void pbxPerso2_Click(object sender, EventArgs e)
        {
            btnChangement.Enabled = true;
            lblChangement.Visible = true;
            choixHero = "Perso2";
            imagePrincipal = pbxPerso1.Image;
            imageSecondaire = pbxPerso1.Image;
        }

        private void pbxPerso3_Click(object sender, EventArgs e)
        {
            btnChangement.Enabled = true;
            lblChangement.Visible = true;
            choixHero = "Perso3";
            imagePrincipal = pbxPerso1.Image;
        }

        private void pbxPerso1_Click(object sender, EventArgs e)
        {
            btnChangement.Enabled = true;
            lblChangement.Visible = true;
            choixHero = "Perso1";
            imagePrincipal = pbxPerso1.Image;
        }
    }
}
