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
            this.bntAttaque = new System.Windows.Forms.Button();
            this.btnDefense = new System.Windows.Forms.Button();
            this.btnChangement = new System.Windows.Forms.Button();
            this.pbxPerso1 = new System.Windows.Forms.PictureBox();
            this.pbxPerso2 = new System.Windows.Forms.PictureBox();
            this.pbxPerso3 = new System.Windows.Forms.PictureBox();
            this.pbxEnnemie = new System.Windows.Forms.PictureBox();
            this.pbrVieEnnemi = new System.Windows.Forms.ProgressBar();
            this.lblChangement = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVieEnnemi = new System.Windows.Forms.Label();
            this.lblViePerso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbrViePerso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemie)).BeginInit();
            this.SuspendLayout();
            // 
            // bntAttaque
            // 
            this.bntAttaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAttaque.Location = new System.Drawing.Point(32, 754);
            this.bntAttaque.Name = "bntAttaque";
            this.bntAttaque.Size = new System.Drawing.Size(229, 92);
            this.bntAttaque.TabIndex = 0;
            this.bntAttaque.Text = "Attaque";
            this.bntAttaque.UseVisualStyleBackColor = true;
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
            // 
            // btnChangement
            // 
            this.btnChangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangement.Location = new System.Drawing.Point(170, 880);
            this.btnChangement.Name = "btnChangement";
            this.btnChangement.Size = new System.Drawing.Size(229, 92);
            this.btnChangement.TabIndex = 2;
            this.btnChangement.Text = "Changement";
            this.btnChangement.UseVisualStyleBackColor = true;
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
            // 
            // pbxEnnemie
            // 
            this.pbxEnnemie.Image = global::P_Heroes.Properties.Resources.Orc_Warriors_Armor_Shield;
            this.pbxEnnemie.Location = new System.Drawing.Point(715, 184);
            this.pbxEnnemie.Name = "pbxEnnemie";
            this.pbxEnnemie.Size = new System.Drawing.Size(266, 349);
            this.pbxEnnemie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEnnemie.TabIndex = 7;
            this.pbxEnnemie.TabStop = false;
            // 
            // pbrVieEnnemi
            // 
            this.pbrVieEnnemi.Location = new System.Drawing.Point(715, 113);
            this.pbrVieEnnemi.Name = "pbrVieEnnemi";
            this.pbrVieEnnemi.Size = new System.Drawing.Size(266, 39);
            this.pbrVieEnnemi.TabIndex = 8;
            this.pbrVieEnnemi.Value = 100;
            // 
            // lblChangement
            // 
            this.lblChangement.AutoSize = true;
            this.lblChangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangement.Location = new System.Drawing.Point(439, 911);
            this.lblChangement.Name = "lblChangement";
            this.lblChangement.Size = new System.Drawing.Size(285, 25);
            this.lblChangement.TabIndex = 9;
            this.lblChangement.Text = "Veuiller changer votre Heros";
            this.lblChangement.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(826, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "PV";
            // 
            // lblVieEnnemi
            // 
            this.lblVieEnnemi.AutoSize = true;
            this.lblVieEnnemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVieEnnemi.Location = new System.Drawing.Point(987, 122);
            this.lblVieEnnemi.Name = "lblVieEnnemi";
            this.lblVieEnnemi.Size = new System.Drawing.Size(36, 20);
            this.lblVieEnnemi.TabIndex = 11;
            this.lblVieEnnemi.Text = "100";
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
            // 
            // pbrViePerso
            // 
            this.pbrViePerso.Location = new System.Drawing.Point(208, 212);
            this.pbrViePerso.Name = "pbrViePerso";
            this.pbrViePerso.Size = new System.Drawing.Size(266, 39);
            this.pbrViePerso.TabIndex = 12;
            this.pbrViePerso.Value = 100;
            // 
            // P_Heros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.lblViePerso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbrViePerso);
            this.Controls.Add(this.lblVieEnnemi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChangement);
            this.Controls.Add(this.pbrVieEnnemi);
            this.Controls.Add(this.pbxEnnemie);
            this.Controls.Add(this.pbxPerso3);
            this.Controls.Add(this.pbxPerso2);
            this.Controls.Add(this.pbxPerso1);
            this.Controls.Add(this.btnChangement);
            this.Controls.Add(this.btnDefense);
            this.Controls.Add(this.bntAttaque);
            this.Name = "P_Heros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heros";
            this.Load += new System.EventHandler(this.P_Heros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnnemie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntAttaque;
        private System.Windows.Forms.Button btnChangement;
        private System.Windows.Forms.PictureBox pbxPerso1;
        private System.Windows.Forms.PictureBox pbxPerso2;
        private System.Windows.Forms.PictureBox pbxPerso3;
        private System.Windows.Forms.PictureBox pbxEnnemie;
        private System.Windows.Forms.ProgressBar pbrVieEnnemi;
        private System.Windows.Forms.Button btnDefense;
        private System.Windows.Forms.Label lblChangement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVieEnnemi;
        private System.Windows.Forms.Label lblViePerso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbrViePerso;
    }
}

