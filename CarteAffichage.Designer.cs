namespace P_Heroes
{
    partial class CarteAffichage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNomHero = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNomHero);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.lblStat);
            this.panel1.Controls.Add(this.pbxImage);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 319);
            this.panel1.TabIndex = 0;
            // 
            // lblNomHero
            // 
            this.lblNomHero.AutoSize = true;
            this.lblNomHero.Location = new System.Drawing.Point(94, 22);
            this.lblNomHero.Name = "lblNomHero";
            this.lblNomHero.Size = new System.Drawing.Size(27, 13);
            this.lblNomHero.TabIndex = 3;
            this.lblNomHero.Text = "nom";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(54, 278);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(105, 38);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Choisir";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lblStat
            // 
            this.lblStat.Location = new System.Drawing.Point(13, 207);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(196, 68);
            this.lblStat.TabIndex = 1;
            this.lblStat.Text = "stats";
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(13, 38);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(196, 166);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // CarteAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel1);
            this.Name = "CarteAffichage";
            this.Size = new System.Drawing.Size(248, 348);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label lblNomHero;
    }
}
