namespace P_Heroes.Model
{
    partial class ObjetInventaire
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
            this.pnlRarete = new System.Windows.Forms.Panel();
            this.pbxMiniature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRarete
            // 
            this.pnlRarete.BackColor = System.Drawing.Color.Gold;
            this.pnlRarete.Location = new System.Drawing.Point(0, 45);
            this.pnlRarete.Name = "pnlRarete";
            this.pnlRarete.Size = new System.Drawing.Size(50, 5);
            this.pnlRarete.TabIndex = 1;
            this.pnlRarete.Click += new System.EventHandler(this.pnlRarete_Click);
            // 
            // pbxMiniature
            // 
            this.pbxMiniature.Image = global::P_Heroes.Properties.Resources.arbalete;
            this.pbxMiniature.Location = new System.Drawing.Point(0, 0);
            this.pbxMiniature.Name = "pbxMiniature";
            this.pbxMiniature.Size = new System.Drawing.Size(50, 50);
            this.pbxMiniature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMiniature.TabIndex = 0;
            this.pbxMiniature.TabStop = false;
            this.pbxMiniature.Click += new System.EventHandler(this.pbxMiniature_Click);
            // 
            // ObjetInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlRarete);
            this.Controls.Add(this.pbxMiniature);
            this.Name = "ObjetInventaire";
            this.Size = new System.Drawing.Size(50, 50);
            this.Click += new System.EventHandler(this.ObjetInventaire_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMiniature;
        private System.Windows.Forms.Panel pnlRarete;
    }
}
