namespace P_Heroes
{
    partial class frmSalon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChoixCompagnie = new System.Windows.Forms.Button();
            this.btnCreerCompagnie = new System.Windows.Forms.Button();
            this.btnInventaire = new System.Windows.Forms.Button();
            this.btnReparation = new System.Windows.Forms.Button();
            this.btnBoutique = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnCampagne = new System.Windows.Forms.Button();
            this.btnMultiJoueur = new System.Windows.Forms.Button();
            this.lblNomCompagnie = new System.Windows.Forms.Label();
            this.lblNumCompagnie = new System.Windows.Forms.Label();
            this.pnlAffichageHeros = new System.Windows.Forms.Panel();
            this.pbxHero3Arme2 = new System.Windows.Forms.PictureBox();
            this.pbxHero3Tenue = new System.Windows.Forms.PictureBox();
            this.pbxHero3Arme1 = new System.Windows.Forms.PictureBox();
            this.pbxHero2Arme2 = new System.Windows.Forms.PictureBox();
            this.pbxHero2Tenue = new System.Windows.Forms.PictureBox();
            this.pbxHero2Arme1 = new System.Windows.Forms.PictureBox();
            this.pbxHero1Arme2 = new System.Windows.Forms.PictureBox();
            this.pbxHero1Tenue = new System.Windows.Forms.PictureBox();
            this.pbxHero1Arme1 = new System.Windows.Forms.PictureBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblPoCompagnie = new System.Windows.Forms.Label();
            this.pgbXp = new System.Windows.Forms.ProgressBar();
            this.lblXpMax = new System.Windows.Forms.Label();
            this.lblXpCompagnie = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblNiveauCompagnie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Arme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Tenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Arme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Arme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Tenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Arme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Arme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Tenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Arme1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoixCompagnie
            // 
            this.btnChoixCompagnie.Enabled = false;
            this.btnChoixCompagnie.Location = new System.Drawing.Point(49, 72);
            this.btnChoixCompagnie.Name = "btnChoixCompagnie";
            this.btnChoixCompagnie.Size = new System.Drawing.Size(159, 32);
            this.btnChoixCompagnie.TabIndex = 0;
            this.btnChoixCompagnie.Text = "Choix de la compagnie";
            this.btnChoixCompagnie.UseVisualStyleBackColor = true;
            this.btnChoixCompagnie.Click += new System.EventHandler(this.btnChoixCompagnie_Click);
            // 
            // btnCreerCompagnie
            // 
            this.btnCreerCompagnie.Location = new System.Drawing.Point(49, 110);
            this.btnCreerCompagnie.Name = "btnCreerCompagnie";
            this.btnCreerCompagnie.Size = new System.Drawing.Size(159, 32);
            this.btnCreerCompagnie.TabIndex = 1;
            this.btnCreerCompagnie.Text = "Créer une compagnie";
            this.btnCreerCompagnie.UseVisualStyleBackColor = true;
            this.btnCreerCompagnie.Click += new System.EventHandler(this.btnCreerCompagnie_Click);
            // 
            // btnInventaire
            // 
            this.btnInventaire.Enabled = false;
            this.btnInventaire.Location = new System.Drawing.Point(49, 199);
            this.btnInventaire.Name = "btnInventaire";
            this.btnInventaire.Size = new System.Drawing.Size(159, 32);
            this.btnInventaire.TabIndex = 2;
            this.btnInventaire.Text = "Inventaire ";
            this.btnInventaire.UseVisualStyleBackColor = true;
            this.btnInventaire.Click += new System.EventHandler(this.btnInventaire_Click);
            // 
            // btnReparation
            // 
            this.btnReparation.Enabled = false;
            this.btnReparation.Location = new System.Drawing.Point(49, 237);
            this.btnReparation.Name = "btnReparation";
            this.btnReparation.Size = new System.Drawing.Size(159, 32);
            this.btnReparation.TabIndex = 3;
            this.btnReparation.Text = "Réparation";
            this.btnReparation.UseVisualStyleBackColor = true;
            this.btnReparation.Click += new System.EventHandler(this.btnReparation_Click);
            // 
            // btnBoutique
            // 
            this.btnBoutique.Enabled = false;
            this.btnBoutique.Location = new System.Drawing.Point(49, 275);
            this.btnBoutique.Name = "btnBoutique";
            this.btnBoutique.Size = new System.Drawing.Size(159, 32);
            this.btnBoutique.TabIndex = 4;
            this.btnBoutique.Text = "Boutique";
            this.btnBoutique.UseVisualStyleBackColor = true;
            this.btnBoutique.Click += new System.EventHandler(this.btnBoutique_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(49, 440);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(159, 32);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnCampagne
            // 
            this.btnCampagne.Enabled = false;
            this.btnCampagne.Location = new System.Drawing.Point(49, 532);
            this.btnCampagne.Name = "btnCampagne";
            this.btnCampagne.Size = new System.Drawing.Size(157, 58);
            this.btnCampagne.TabIndex = 7;
            this.btnCampagne.Text = "Campagne";
            this.btnCampagne.UseVisualStyleBackColor = true;
            this.btnCampagne.Click += new System.EventHandler(this.btnCampagne_Click);
            // 
            // btnMultiJoueur
            // 
            this.btnMultiJoueur.Enabled = false;
            this.btnMultiJoueur.Location = new System.Drawing.Point(49, 596);
            this.btnMultiJoueur.Name = "btnMultiJoueur";
            this.btnMultiJoueur.Size = new System.Drawing.Size(157, 58);
            this.btnMultiJoueur.TabIndex = 8;
            this.btnMultiJoueur.Text = "Multijoueur";
            this.btnMultiJoueur.UseVisualStyleBackColor = true;
            // 
            // lblNomCompagnie
            // 
            this.lblNomCompagnie.AutoSize = true;
            this.lblNomCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCompagnie.Location = new System.Drawing.Point(646, 78);
            this.lblNomCompagnie.Name = "lblNomCompagnie";
            this.lblNomCompagnie.Size = new System.Drawing.Size(141, 16);
            this.lblNomCompagnie.TabIndex = 12;
            this.lblNomCompagnie.Text = "Nom de la compagnie";
            this.lblNomCompagnie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumCompagnie
            // 
            this.lblNumCompagnie.AutoSize = true;
            this.lblNumCompagnie.Location = new System.Drawing.Point(214, 82);
            this.lblNumCompagnie.Name = "lblNumCompagnie";
            this.lblNumCompagnie.Size = new System.Drawing.Size(30, 13);
            this.lblNumCompagnie.TabIndex = 13;
            this.lblNumCompagnie.Text = "0 / 6";
            // 
            // pnlAffichageHeros
            // 
            this.pnlAffichageHeros.Location = new System.Drawing.Point(234, 110);
            this.pnlAffichageHeros.Name = "pnlAffichageHeros";
            this.pnlAffichageHeros.Size = new System.Drawing.Size(826, 418);
            this.pnlAffichageHeros.TabIndex = 14;
            // 
            // pbxHero3Arme2
            // 
            this.pbxHero3Arme2.Location = new System.Drawing.Point(923, 672);
            this.pbxHero3Arme2.Name = "pbxHero3Arme2";
            this.pbxHero3Arme2.Size = new System.Drawing.Size(100, 100);
            this.pbxHero3Arme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero3Arme2.TabIndex = 23;
            this.pbxHero3Arme2.TabStop = false;
            // 
            // pbxHero3Tenue
            // 
            this.pbxHero3Tenue.Location = new System.Drawing.Point(864, 554);
            this.pbxHero3Tenue.Name = "pbxHero3Tenue";
            this.pbxHero3Tenue.Size = new System.Drawing.Size(100, 100);
            this.pbxHero3Tenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero3Tenue.TabIndex = 22;
            this.pbxHero3Tenue.TabStop = false;
            // 
            // pbxHero3Arme1
            // 
            this.pbxHero3Arme1.Location = new System.Drawing.Point(805, 672);
            this.pbxHero3Arme1.Name = "pbxHero3Arme1";
            this.pbxHero3Arme1.Size = new System.Drawing.Size(100, 100);
            this.pbxHero3Arme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero3Arme1.TabIndex = 21;
            this.pbxHero3Arme1.TabStop = false;
            // 
            // pbxHero2Arme2
            // 
            this.pbxHero2Arme2.Location = new System.Drawing.Point(649, 672);
            this.pbxHero2Arme2.Name = "pbxHero2Arme2";
            this.pbxHero2Arme2.Size = new System.Drawing.Size(100, 100);
            this.pbxHero2Arme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero2Arme2.TabIndex = 20;
            this.pbxHero2Arme2.TabStop = false;
            // 
            // pbxHero2Tenue
            // 
            this.pbxHero2Tenue.Location = new System.Drawing.Point(594, 554);
            this.pbxHero2Tenue.Name = "pbxHero2Tenue";
            this.pbxHero2Tenue.Size = new System.Drawing.Size(100, 100);
            this.pbxHero2Tenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero2Tenue.TabIndex = 19;
            this.pbxHero2Tenue.TabStop = false;
            // 
            // pbxHero2Arme1
            // 
            this.pbxHero2Arme1.Location = new System.Drawing.Point(531, 672);
            this.pbxHero2Arme1.Name = "pbxHero2Arme1";
            this.pbxHero2Arme1.Size = new System.Drawing.Size(100, 100);
            this.pbxHero2Arme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero2Arme1.TabIndex = 18;
            this.pbxHero2Arme1.TabStop = false;
            // 
            // pbxHero1Arme2
            // 
            this.pbxHero1Arme2.Location = new System.Drawing.Point(365, 672);
            this.pbxHero1Arme2.Name = "pbxHero1Arme2";
            this.pbxHero1Arme2.Size = new System.Drawing.Size(100, 100);
            this.pbxHero1Arme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero1Arme2.TabIndex = 17;
            this.pbxHero1Arme2.TabStop = false;
            // 
            // pbxHero1Tenue
            // 
            this.pbxHero1Tenue.Location = new System.Drawing.Point(307, 554);
            this.pbxHero1Tenue.Name = "pbxHero1Tenue";
            this.pbxHero1Tenue.Size = new System.Drawing.Size(100, 100);
            this.pbxHero1Tenue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero1Tenue.TabIndex = 16;
            this.pbxHero1Tenue.TabStop = false;
            // 
            // pbxHero1Arme1
            // 
            this.pbxHero1Arme1.Location = new System.Drawing.Point(244, 672);
            this.pbxHero1Arme1.Name = "pbxHero1Arme1";
            this.pbxHero1Arme1.Size = new System.Drawing.Size(100, 100);
            this.pbxHero1Arme1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero1Arme1.TabIndex = 15;
            this.pbxHero1Arme1.TabStop = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(886, 72);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(31, 16);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Po :";
            // 
            // lblPoCompagnie
            // 
            this.lblPoCompagnie.AutoSize = true;
            this.lblPoCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoCompagnie.Location = new System.Drawing.Point(923, 72);
            this.lblPoCompagnie.Name = "lblPoCompagnie";
            this.lblPoCompagnie.Size = new System.Drawing.Size(0, 16);
            this.lblPoCompagnie.TabIndex = 24;
            // 
            // pgbXp
            // 
            this.pgbXp.Location = new System.Drawing.Point(324, 72);
            this.pgbXp.Maximum = 1000;
            this.pgbXp.Name = "pgbXp";
            this.pgbXp.Size = new System.Drawing.Size(212, 23);
            this.pgbXp.TabIndex = 25;
            // 
            // lblXpMax
            // 
            this.lblXpMax.AutoSize = true;
            this.lblXpMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXpMax.Location = new System.Drawing.Point(542, 78);
            this.lblXpMax.Name = "lblXpMax";
            this.lblXpMax.Size = new System.Drawing.Size(40, 17);
            this.lblXpMax.TabIndex = 26;
            this.lblXpMax.Text = "1000";
            // 
            // lblXpCompagnie
            // 
            this.lblXpCompagnie.AutoSize = true;
            this.lblXpCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXpCompagnie.Location = new System.Drawing.Point(285, 77);
            this.lblXpCompagnie.Name = "lblXpCompagnie";
            this.lblXpCompagnie.Size = new System.Drawing.Size(16, 17);
            this.lblXpCompagnie.TabIndex = 27;
            this.lblXpCompagnie.Text = "0";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(362, 52);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(60, 17);
            this.lbl4.TabIndex = 28;
            this.lbl4.Text = "Niveau :";
            // 
            // lblNiveauCompagnie
            // 
            this.lblNiveauCompagnie.AutoSize = true;
            this.lblNiveauCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveauCompagnie.Location = new System.Drawing.Point(428, 52);
            this.lblNiveauCompagnie.Name = "lblNiveauCompagnie";
            this.lblNiveauCompagnie.Size = new System.Drawing.Size(0, 17);
            this.lblNiveauCompagnie.TabIndex = 29;
            // 
            // frmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.lblNiveauCompagnie);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblXpCompagnie);
            this.Controls.Add(this.lblXpMax);
            this.Controls.Add(this.pgbXp);
            this.Controls.Add(this.lblPoCompagnie);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pbxHero3Arme2);
            this.Controls.Add(this.pbxHero3Tenue);
            this.Controls.Add(this.pbxHero3Arme1);
            this.Controls.Add(this.pbxHero2Arme2);
            this.Controls.Add(this.pbxHero2Tenue);
            this.Controls.Add(this.pbxHero2Arme1);
            this.Controls.Add(this.pbxHero1Arme2);
            this.Controls.Add(this.pbxHero1Tenue);
            this.Controls.Add(this.pbxHero1Arme1);
            this.Controls.Add(this.pnlAffichageHeros);
            this.Controls.Add(this.lblNumCompagnie);
            this.Controls.Add(this.lblNomCompagnie);
            this.Controls.Add(this.btnMultiJoueur);
            this.Controls.Add(this.btnCampagne);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnBoutique);
            this.Controls.Add(this.btnReparation);
            this.Controls.Add(this.btnInventaire);
            this.Controls.Add(this.btnCreerCompagnie);
            this.Controls.Add(this.btnChoixCompagnie);
            this.Name = "frmSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon";
            this.Load += new System.EventHandler(this.frmSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Arme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Tenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3Arme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Arme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Tenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2Arme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Arme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Tenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1Arme1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoixCompagnie;
        private System.Windows.Forms.Button btnCreerCompagnie;
        private System.Windows.Forms.Button btnInventaire;
        private System.Windows.Forms.Button btnReparation;
        private System.Windows.Forms.Button btnBoutique;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnCampagne;
        private System.Windows.Forms.Button btnMultiJoueur;
        private System.Windows.Forms.Label lblNomCompagnie;
        private System.Windows.Forms.Label lblNumCompagnie;
        private System.Windows.Forms.Panel pnlAffichageHeros;
        private System.Windows.Forms.PictureBox pbxHero3Arme2;
        private System.Windows.Forms.PictureBox pbxHero3Tenue;
        private System.Windows.Forms.PictureBox pbxHero3Arme1;
        private System.Windows.Forms.PictureBox pbxHero2Arme2;
        private System.Windows.Forms.PictureBox pbxHero2Tenue;
        private System.Windows.Forms.PictureBox pbxHero2Arme1;
        private System.Windows.Forms.PictureBox pbxHero1Arme2;
        private System.Windows.Forms.PictureBox pbxHero1Tenue;
        private System.Windows.Forms.PictureBox pbxHero1Arme1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblPoCompagnie;
        private System.Windows.Forms.ProgressBar pgbXp;
        private System.Windows.Forms.Label lblXpMax;
        private System.Windows.Forms.Label lblXpCompagnie;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblNiveauCompagnie;
    }
}