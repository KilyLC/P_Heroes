namespace P_Heroes
{
    partial class frmAccueil
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
            this.btnSolo = new System.Windows.Forms.Button();
            this.btnMultijoueur = new System.Windows.Forms.Button();
            this.btnBoutique = new System.Windows.Forms.Button();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolo
            // 
            this.btnSolo.Location = new System.Drawing.Point(80, 44);
            this.btnSolo.Name = "btnSolo";
            this.btnSolo.Size = new System.Drawing.Size(122, 89);
            this.btnSolo.TabIndex = 0;
            this.btnSolo.Text = "Solo";
            this.btnSolo.UseVisualStyleBackColor = true;
            this.btnSolo.Click += new System.EventHandler(this.btnSolo_Click);
            // 
            // btnMultijoueur
            // 
            this.btnMultijoueur.Location = new System.Drawing.Point(294, 44);
            this.btnMultijoueur.Name = "btnMultijoueur";
            this.btnMultijoueur.Size = new System.Drawing.Size(122, 89);
            this.btnMultijoueur.TabIndex = 1;
            this.btnMultijoueur.Text = "Multijoueur";
            this.btnMultijoueur.UseVisualStyleBackColor = true;
            this.btnMultijoueur.Click += new System.EventHandler(this.btnMultijoueur_Click);
            // 
            // btnBoutique
            // 
            this.btnBoutique.Location = new System.Drawing.Point(80, 187);
            this.btnBoutique.Name = "btnBoutique";
            this.btnBoutique.Size = new System.Drawing.Size(122, 89);
            this.btnBoutique.TabIndex = 2;
            this.btnBoutique.Text = "Boutique";
            this.btnBoutique.UseVisualStyleBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(294, 187);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(122, 89);
            this.btnOption.TabIndex = 3;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(191, 323);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(122, 89);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.btnBoutique);
            this.Controls.Add(this.btnMultijoueur);
            this.Controls.Add(this.btnSolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.Text = "frmAccueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSolo;
        private System.Windows.Forms.Button btnMultijoueur;
        private System.Windows.Forms.Button btnBoutique;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnQuitter;
    }
}