namespace P_Heroes
{
    partial class FrmBoutique
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
            this.tctrlBoutique = new System.Windows.Forms.TabControl();
            this.tpgAcheter = new System.Windows.Forms.TabPage();
            this.tpgVendre = new System.Windows.Forms.TabPage();
            this.lblInventaireVide = new System.Windows.Forms.Label();
            this.lblArgent = new System.Windows.Forms.Label();
            this.tctrlBoutique.SuspendLayout();
            this.tpgVendre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlBoutique
            // 
            this.tctrlBoutique.Controls.Add(this.tpgAcheter);
            this.tctrlBoutique.Controls.Add(this.tpgVendre);
            this.tctrlBoutique.Location = new System.Drawing.Point(0, 31);
            this.tctrlBoutique.Name = "tctrlBoutique";
            this.tctrlBoutique.SelectedIndex = 0;
            this.tctrlBoutique.Size = new System.Drawing.Size(800, 420);
            this.tctrlBoutique.TabIndex = 0;
            // 
            // tpgAcheter
            // 
            this.tpgAcheter.AutoScroll = true;
            this.tpgAcheter.Location = new System.Drawing.Point(4, 22);
            this.tpgAcheter.Name = "tpgAcheter";
            this.tpgAcheter.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAcheter.Size = new System.Drawing.Size(792, 394);
            this.tpgAcheter.TabIndex = 0;
            this.tpgAcheter.Text = "Acheter";
            this.tpgAcheter.UseVisualStyleBackColor = true;
            // 
            // tpgVendre
            // 
            this.tpgVendre.AutoScroll = true;
            this.tpgVendre.Controls.Add(this.lblInventaireVide);
            this.tpgVendre.Location = new System.Drawing.Point(4, 22);
            this.tpgVendre.Name = "tpgVendre";
            this.tpgVendre.Padding = new System.Windows.Forms.Padding(3);
            this.tpgVendre.Size = new System.Drawing.Size(792, 394);
            this.tpgVendre.TabIndex = 1;
            this.tpgVendre.Text = "Vendre";
            this.tpgVendre.UseVisualStyleBackColor = true;
            // 
            // lblInventaireVide
            // 
            this.lblInventaireVide.AutoSize = true;
            this.lblInventaireVide.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventaireVide.Location = new System.Drawing.Point(19, 142);
            this.lblInventaireVide.Name = "lblInventaireVide";
            this.lblInventaireVide.Size = new System.Drawing.Size(755, 73);
            this.lblInventaireVide.TabIndex = 0;
            this.lblInventaireVide.Text = "Votre inventaire est vide !";
            this.lblInventaireVide.Visible = false;
            // 
            // lblArgent
            // 
            this.lblArgent.AutoSize = true;
            this.lblArgent.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgent.ForeColor = System.Drawing.Color.White;
            this.lblArgent.Location = new System.Drawing.Point(12, 2);
            this.lblArgent.Name = "lblArgent";
            this.lblArgent.Size = new System.Drawing.Size(107, 26);
            this.lblArgent.TabIndex = 0;
            this.lblArgent.Text = "Argent";
            // 
            // FrmBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArgent);
            this.Controls.Add(this.tctrlBoutique);
            this.Name = "FrmBoutique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boutique";
            this.tctrlBoutique.ResumeLayout(false);
            this.tpgVendre.ResumeLayout(false);
            this.tpgVendre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlBoutique;
        private System.Windows.Forms.TabPage tpgAcheter;
        private System.Windows.Forms.TabPage tpgVendre;
        private System.Windows.Forms.Label lblArgent;
        private System.Windows.Forms.Label lblInventaireVide;
    }
}