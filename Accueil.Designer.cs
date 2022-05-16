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
            this.lblNbVolume = new System.Windows.Forms.Label();
            this.hsbVolume = new System.Windows.Forms.HScrollBar();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNbVolume
            // 
            this.lblNbVolume.AutoSize = true;
            this.lblNbVolume.Location = new System.Drawing.Point(496, 701);
            this.lblNbVolume.Name = "lblNbVolume";
            this.lblNbVolume.Size = new System.Drawing.Size(35, 13);
            this.lblNbVolume.TabIndex = 14;
            this.lblNbVolume.Text = "label2";
            // 
            // hsbVolume
            // 
            this.hsbVolume.LargeChange = 1;
            this.hsbVolume.Location = new System.Drawing.Point(401, 665);
            this.hsbVolume.Name = "hsbVolume";
            this.hsbVolume.Size = new System.Drawing.Size(235, 27);
            this.hsbVolume.TabIndex = 13;
            this.hsbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbVolume_Scroll);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(274, 294);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(205, 128);
            this.btnJouer.TabIndex = 11;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(593, 294);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(205, 128);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // P_Heros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.lblNbVolume);
            this.Controls.Add(this.hsbVolume);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnQuitter);
            this.Name = "P_Heros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.P_Heros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNbVolume;
        private System.Windows.Forms.HScrollBar hsbVolume;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

