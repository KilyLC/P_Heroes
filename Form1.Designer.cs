namespace P_Heroes
{
    partial class P_Heros
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAttaque = new System.Windows.Forms.Button();
            this.btnDefense = new System.Windows.Forms.Button();
            this.btnChangement = new System.Windows.Forms.Button();
            this.pbxPerso1 = new System.Windows.Forms.PictureBox();
            this.pbxPerso2 = new System.Windows.Forms.PictureBox();
            this.pbxPerso3 = new System.Windows.Forms.PictureBox();
            this.pbxEnnemi1 = new System.Windows.Forms.PictureBox();
            this.pbrVieEnnemi = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVieEnnemi = new System.Windows.Forms.Label();
            this.lblViePerso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbrViePerso = new System.Windows.Forms.ProgressBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblNomCompagnie = new System.Windows.Forms.Label();
            this.btnCommencer = new System.Windows.Forms.Button();
            this.lblNomHero = new System.Windows.Forms.Label();
            this.lbxAction = new System.Windows.Forms.ListBox();
            this.btnCapaciteSpecial = new System.Windows.Forms.Button();
            this.btnFinTour = new System.Windows.Forms.Button();
            this.pbxEnnemi3 = new System.Windows.Forms.PictureBox();
            this.pbxEnnemi2 = new System.Windows.Forms.PictureBox();
            this.lblNomCompagnieEnnemi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomEnnemi = new System.Windows.Forms.Label();
            this.lbxAffichage = new System.Windows.Forms.ListBox();
            this.lbl5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttaque
            // 
            this.btnAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttaque.Location = new System.Drawing.Point(32, 754);
            this.btnAttaque.Name = "btnAttaque";
            this.btnAttaque.Size = new System.Drawing.Size(229, 92);
            this.btnAttaque.TabIndex = 0;
            this.btnAttaque.Text = "Attaque";
            this.btnAttaque.UseVisualStyleBackColor = true;
            this.btnAttaque.Visible = false;
            this.btnAttaque.Click += new System.EventHandler(this.btnAttaque_Click);
            // 
            // btnDefense
            // 
            this.btnDefense.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDefense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefense.Location = new System.Drawing.Point(292, 754);
            this.btnDefense.Name = "btnDefense";
            this.btnDefense.Size = new System.Drawing.Size(229, 92);
            this.btnDefense.TabIndex = 1;
            this.btnDefense.Text = "Defense";
            this.btnDefense.UseVisualStyleBackColor = true;
            this.btnDefense.Visible = false;
            this.btnDefense.Click += new System.EventHandler(this.btnDefense_Click);
            // 
            // btnChangement
            // 
            this.btnChangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangement.Location = new System.Drawing.Point(32, 873);
            this.btnChangement.Name = "btnChangement";
            this.btnChangement.Size = new System.Drawing.Size(229, 92);
            this.btnChangement.TabIndex = 2;
            this.btnChangement.Text = "Changement";
            this.btnChangement.UseVisualStyleBackColor = true;
            this.btnChangement.Visible = false;
            this.btnChangement.Click += new System.EventHandler(this.btnChangement_Click);
            // 
            // pbxPerso1
            // 
            this.pbxPerso1.Image = global::P_Heroes.Properties.Resources.Hero1;
            this.pbxPerso1.Location = new System.Drawing.Point(230, 257);
            this.pbxPerso1.Name = "pbxPerso1";
            this.pbxPerso1.Size = new System.Drawing.Size(215, 184);
            this.pbxPerso1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerso1.TabIndex = 4;
            this.pbxPerso1.TabStop = false;
            this.pbxPerso1.Tag = "hero1";
            this.pbxPerso1.Visible = false;
            // 
            // pbxPerso2
            // 
            this.pbxPerso2.Image = global::P_Heroes.Properties.Resources.Hero3;
            this.pbxPerso2.Location = new System.Drawing.Point(65, 53);
            this.pbxPerso2.Name = "pbxPerso2";
            this.pbxPerso2.Size = new System.Drawing.Size(156, 156);
            this.pbxPerso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerso2.TabIndex = 5;
            this.pbxPerso2.TabStop = false;
            this.pbxPerso2.Tag = "hero3";
            this.pbxPerso2.Visible = false;
            // 
            // pbxPerso3
            // 
            this.pbxPerso3.Image = global::P_Heroes.Properties.Resources.Hero2;
            this.pbxPerso3.Location = new System.Drawing.Point(65, 475);
            this.pbxPerso3.Name = "pbxPerso3";
            this.pbxPerso3.Size = new System.Drawing.Size(156, 156);
            this.pbxPerso3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPerso3.TabIndex = 6;
            this.pbxPerso3.TabStop = false;
            this.pbxPerso3.Tag = "hero2";
            this.pbxPerso3.Visible = false;
            // 
            // pbxEnnemi1
            // 
            this.pbxEnnemi1.Image = global::P_Heroes.Properties.Resources.Orc_Warriors_Armor_Shield;
            this.pbxEnnemi1.Location = new System.Drawing.Point(594, 257);
            this.pbxEnnemi1.Name = "pbxEnnemi1";
            this.pbxEnnemi1.Size = new System.Drawing.Size(252, 184);
            this.pbxEnnemi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnnemi1.TabIndex = 7;
            this.pbxEnnemi1.TabStop = false;
            this.pbxEnnemi1.Visible = false;
            // 
            // pbrVieEnnemi
            // 
            this.pbrVieEnnemi.Location = new System.Drawing.Point(594, 212);
            this.pbrVieEnnemi.Name = "pbrVieEnnemi";
            this.pbrVieEnnemi.Size = new System.Drawing.Size(272, 39);
            this.pbrVieEnnemi.TabIndex = 8;
            this.pbrVieEnnemi.Value = 100;
            this.pbrVieEnnemi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "PV";
            this.label1.Visible = false;
            // 
            // lblVieEnnemi
            // 
            this.lblVieEnnemi.AutoSize = true;
            this.lblVieEnnemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVieEnnemi.Location = new System.Drawing.Point(552, 221);
            this.lblVieEnnemi.Name = "lblVieEnnemi";
            this.lblVieEnnemi.Size = new System.Drawing.Size(36, 20);
            this.lblVieEnnemi.TabIndex = 11;
            this.lblVieEnnemi.Text = "100";
            this.lblVieEnnemi.Visible = false;
            // 
            // lblViePerso
            // 
            this.lblViePerso.AutoSize = true;
            this.lblViePerso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViePerso.Location = new System.Drawing.Point(480, 221);
            this.lblViePerso.Name = "lblViePerso";
            this.lblViePerso.Size = new System.Drawing.Size(36, 20);
            this.lblViePerso.TabIndex = 14;
            this.lblViePerso.Text = "100";
            this.lblViePerso.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "PV";
            this.label4.Visible = false;
            // 
            // pbrViePerso
            // 
            this.pbrViePerso.Location = new System.Drawing.Point(208, 212);
            this.pbrViePerso.Name = "pbrViePerso";
            this.pbrViePerso.Size = new System.Drawing.Size(266, 39);
            this.pbrViePerso.TabIndex = 12;
            this.pbrViePerso.Value = 100;
            this.pbrViePerso.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(205, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(87, 17);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Compagnie :";
            this.lbl1.Visible = false;
            // 
            // lblNomCompagnie
            // 
            this.lblNomCompagnie.AutoSize = true;
            this.lblNomCompagnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCompagnie.Location = new System.Drawing.Point(298, 9);
            this.lblNomCompagnie.Name = "lblNomCompagnie";
            this.lblNomCompagnie.Size = new System.Drawing.Size(0, 17);
            this.lblNomCompagnie.TabIndex = 16;
            this.lblNomCompagnie.Visible = false;
            // 
            // btnCommencer
            // 
            this.btnCommencer.Location = new System.Drawing.Point(402, 244);
            this.btnCommencer.Name = "btnCommencer";
            this.btnCommencer.Size = new System.Drawing.Size(255, 229);
            this.btnCommencer.TabIndex = 17;
            this.btnCommencer.Text = "Commencer";
            this.btnCommencer.UseVisualStyleBackColor = true;
            this.btnCommencer.Click += new System.EventHandler(this.btnCommencer_Click);
            // 
            // lblNomHero
            // 
            this.lblNomHero.AutoSize = true;
            this.lblNomHero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHero.Location = new System.Drawing.Point(321, 465);
            this.lblNomHero.Name = "lblNomHero";
            this.lblNomHero.Size = new System.Drawing.Size(0, 17);
            this.lblNomHero.TabIndex = 18;
            this.lblNomHero.Visible = false;
            // 
            // lbxAction
            // 
            this.lbxAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAction.FormattingEnabled = true;
            this.lbxAction.ItemHeight = 20;
            this.lbxAction.Location = new System.Drawing.Point(760, 693);
            this.lbxAction.Name = "lbxAction";
            this.lbxAction.Size = new System.Drawing.Size(221, 304);
            this.lbxAction.TabIndex = 19;
            this.lbxAction.Visible = false;
            // 
            // btnCapaciteSpecial
            // 
            this.btnCapaciteSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapaciteSpecial.Location = new System.Drawing.Point(292, 873);
            this.btnCapaciteSpecial.Name = "btnCapaciteSpecial";
            this.btnCapaciteSpecial.Size = new System.Drawing.Size(229, 92);
            this.btnCapaciteSpecial.TabIndex = 20;
            this.btnCapaciteSpecial.Text = "Capacité spécial";
            this.btnCapaciteSpecial.UseVisualStyleBackColor = true;
            this.btnCapaciteSpecial.Visible = false;
            // 
            // btnFinTour
            // 
            this.btnFinTour.Enabled = false;
            this.btnFinTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinTour.Location = new System.Drawing.Point(542, 820);
            this.btnFinTour.Name = "btnFinTour";
            this.btnFinTour.Size = new System.Drawing.Size(151, 62);
            this.btnFinTour.TabIndex = 21;
            this.btnFinTour.Text = "Fin de tour";
            this.btnFinTour.UseVisualStyleBackColor = true;
            this.btnFinTour.Visible = false;
            this.btnFinTour.Click += new System.EventHandler(this.btnFinTour_Click);
            // 
            // pbxEnnemi3
            // 
            this.pbxEnnemi3.Image = global::P_Heroes.Properties.Resources.OrcArcherCuir;
            this.pbxEnnemi3.Location = new System.Drawing.Point(809, 475);
            this.pbxEnnemi3.Name = "pbxEnnemi3";
            this.pbxEnnemi3.Size = new System.Drawing.Size(179, 156);
            this.pbxEnnemi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnnemi3.TabIndex = 22;
            this.pbxEnnemi3.TabStop = false;
            this.pbxEnnemi3.Visible = false;
            // 
            // pbxEnnemi2
            // 
            this.pbxEnnemi2.Image = global::P_Heroes.Properties.Resources.OrcArcherCuir;
            this.pbxEnnemi2.Location = new System.Drawing.Point(809, 53);
            this.pbxEnnemi2.Name = "pbxEnnemi2";
            this.pbxEnnemi2.Size = new System.Drawing.Size(172, 156);
            this.pbxEnnemi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnnemi2.TabIndex = 23;
            this.pbxEnnemi2.TabStop = false;
            this.pbxEnnemi2.Visible = false;
            // 
            // lblNomCompagnieEnnemi
            // 
            this.lblNomCompagnieEnnemi.AutoSize = true;
            this.lblNomCompagnieEnnemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCompagnieEnnemi.Location = new System.Drawing.Point(850, 9);
            this.lblNomCompagnieEnnemi.Name = "lblNomCompagnieEnnemi";
            this.lblNomCompagnieEnnemi.Size = new System.Drawing.Size(0, 17);
            this.lblNomCompagnieEnnemi.TabIndex = 25;
            this.lblNomCompagnieEnnemi.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(757, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Compagnie :";
            this.label3.Visible = false;
            // 
            // lblNomEnnemi
            // 
            this.lblNomEnnemi.AutoSize = true;
            this.lblNomEnnemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEnnemi.Location = new System.Drawing.Point(693, 465);
            this.lblNomEnnemi.Name = "lblNomEnnemi";
            this.lblNomEnnemi.Size = new System.Drawing.Size(0, 17);
            this.lblNomEnnemi.TabIndex = 26;
            this.lblNomEnnemi.Visible = false;
            // 
            // lbxAffichage
            // 
            this.lbxAffichage.FormattingEnabled = true;
            this.lbxAffichage.Location = new System.Drawing.Point(402, 25);
            this.lbxAffichage.Name = "lbxAffichage";
            this.lbxAffichage.Size = new System.Drawing.Size(262, 134);
            this.lbxAffichage.TabIndex = 27;
            this.lbxAffichage.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(757, 666);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(62, 17);
            this.lbl5.TabIndex = 29;
            this.lbl5.Text = "Actions :";
            this.lbl5.Visible = false;
            // 
            // P_Heros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbxAffichage);
            this.Controls.Add(this.lblNomEnnemi);
            this.Controls.Add(this.lblNomCompagnieEnnemi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxEnnemi2);
            this.Controls.Add(this.pbxEnnemi3);
            this.Controls.Add(this.btnFinTour);
            this.Controls.Add(this.btnCapaciteSpecial);
            this.Controls.Add(this.lbxAction);
            this.Controls.Add(this.lblNomHero);
            this.Controls.Add(this.btnCommencer);
            this.Controls.Add(this.lblNomCompagnie);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblViePerso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbrViePerso);
            this.Controls.Add(this.lblVieEnnemi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrVieEnnemi);
            this.Controls.Add(this.pbxEnnemi1);
            this.Controls.Add(this.pbxPerso3);
            this.Controls.Add(this.pbxPerso2);
            this.Controls.Add(this.pbxPerso1);
            this.Controls.Add(this.btnChangement);
            this.Controls.Add(this.btnDefense);
            this.Controls.Add(this.btnAttaque);
            this.Name = "P_Heros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heros";
            this.Load += new System.EventHandler(this.P_Heros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemi2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttaque;
        private System.Windows.Forms.Button btnChangement;
        private System.Windows.Forms.PictureBox pbxPerso1;
        private System.Windows.Forms.PictureBox pbxPerso2;
        private System.Windows.Forms.PictureBox pbxPerso3;
        private System.Windows.Forms.PictureBox pbxEnnemi1;
        private System.Windows.Forms.ProgressBar pbrVieEnnemi;
        private System.Windows.Forms.Button btnDefense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVieEnnemi;
        private System.Windows.Forms.Label lblViePerso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbrViePerso;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblNomCompagnie;
        private System.Windows.Forms.Button btnCommencer;
        private System.Windows.Forms.Label lblNomHero;
        private System.Windows.Forms.ListBox lbxAction;
        private System.Windows.Forms.Button btnCapaciteSpecial;
        private System.Windows.Forms.Button btnFinTour;
        private System.Windows.Forms.PictureBox pbxEnnemi3;
        private System.Windows.Forms.PictureBox pbxEnnemi2;
        private System.Windows.Forms.Label lblNomCompagnieEnnemi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomEnnemi;
        private System.Windows.Forms.ListBox lbxAffichage;
        private System.Windows.Forms.Label lbl5;
    }
}

