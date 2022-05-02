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
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(35, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(212, 77);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.BackColor = System.Drawing.Color.MistyRose;
            this.lblNiveau.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveau.Location = new System.Drawing.Point(7, 9);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(22, 25);
            this.lblNiveau.TabIndex = 1;
            this.lblNiveau.Text = "1";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(39, 158);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(159, 64);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Cette armure va vous aider à encaisser les coups";
            // 
            // lblStatsGauche
            // 
            this.lblStatsGauche.Location = new System.Drawing.Point(39, 222);
            this.lblStatsGauche.Name = "lblStatsGauche";
            this.lblStatsGauche.Size = new System.Drawing.Size(159, 64);
            this.lblStatsGauche.TabIndex = 3;
            this.lblStatsGauche.Text = "-1 Agilité\r\n+2 Défense";
            // 
            // pbxMiniature
            // 
            this.pbxMiniature.BackColor = System.Drawing.Color.IndianRed;
            this.pbxMiniature.Location = new System.Drawing.Point(42, 80);
            this.pbxMiniature.Name = "pbxMiniature";
            this.pbxMiniature.Size = new System.Drawing.Size(156, 59);
            this.pbxMiniature.TabIndex = 4;
            this.pbxMiniature.TabStop = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(80, 289);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "button1";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.pbxMiniature);
            this.Controls.Add(this.lblStatsGauche);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.lblNom);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(248, 348);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatsGauche;
        private System.Windows.Forms.PictureBox pbxMiniature;
        private System.Windows.Forms.Button btnAction;
    }
}
