namespace P_Heroes
{
    partial class ShopItem
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatsGauche = new System.Windows.Forms.Label();
            this.pbxMiniature = new System.Windows.Forms.PictureBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(42, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(166, 55);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Armure peu commune";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.BackColor = System.Drawing.Color.MistyRose;
            this.lblNiveau.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveau.Location = new System.Drawing.Point(14, 12);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(22, 25);
            this.lblNiveau.TabIndex = 1;
            this.lblNiveau.Text = "1";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(142, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 62);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Cette armure va vous aider à encaisser les coups";
            // 
            // lblStatsGauche
            // 
            this.lblStatsGauche.Location = new System.Drawing.Point(26, 189);
            this.lblStatsGauche.Name = "lblStatsGauche";
            this.lblStatsGauche.Size = new System.Drawing.Size(85, 62);
            this.lblStatsGauche.TabIndex = 3;
            this.lblStatsGauche.Text = "-1 Agilité\r\n+2 Défense";
            // 
            // pbxMiniature
            // 
            this.pbxMiniature.BackColor = System.Drawing.Color.Transparent;
            this.pbxMiniature.Image = global::P_Heroes.Properties.Resources.metal;
            this.pbxMiniature.Location = new System.Drawing.Point(12, 70);
            this.pbxMiniature.Name = "pbxMiniature";
            this.pbxMiniature.Size = new System.Drawing.Size(200, 111);
            this.pbxMiniature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMiniature.TabIndex = 4;
            this.pbxMiniature.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(29, 283);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(179, 23);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "500$";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.lblNiveau);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.lblStatsGauche);
            this.panel1.Controls.Add(this.pbxMiniature);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 324);
            this.panel1.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(29, 254);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(179, 23);
            this.btnPlus.TabIndex = 6;
            this.btnPlus.Text = "Voir plus";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(248, 348);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatsGauche;
        private System.Windows.Forms.PictureBox pbxMiniature;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlus;
    }
}
