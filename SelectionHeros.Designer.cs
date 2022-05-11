namespace P_Heroes
{
    partial class SelectionHeros
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNomCampagnie = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.pbxHero1 = new System.Windows.Forms.PictureBox();
            this.pbxHero2 = new System.Windows.Forms.PictureBox();
            this.pbxHero3 = new System.Windows.Forms.PictureBox();
            this.pnlAffichageHero = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la compagnie :";
            // 
            // tbxNomCampagnie
            // 
            this.tbxNomCampagnie.Location = new System.Drawing.Point(303, 56);
            this.tbxNomCampagnie.Name = "tbxNomCampagnie";
            this.tbxNomCampagnie.Size = new System.Drawing.Size(343, 20);
            this.tbxNomCampagnie.TabIndex = 1;
            this.tbxNomCampagnie.TextChanged += new System.EventHandler(this.tbxNomCampagnie_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(865, 144);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(184, 73);
            this.btnValider.TabIndex = 23;
            this.btnValider.Text = "Valider vos héros";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // pbxHero1
            // 
            this.pbxHero1.Location = new System.Drawing.Point(217, 115);
            this.pbxHero1.Name = "pbxHero1";
            this.pbxHero1.Size = new System.Drawing.Size(124, 113);
            this.pbxHero1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero1.TabIndex = 24;
            this.pbxHero1.TabStop = false;
            // 
            // pbxHero2
            // 
            this.pbxHero2.Location = new System.Drawing.Point(402, 115);
            this.pbxHero2.Name = "pbxHero2";
            this.pbxHero2.Size = new System.Drawing.Size(124, 113);
            this.pbxHero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero2.TabIndex = 25;
            this.pbxHero2.TabStop = false;
            // 
            // pbxHero3
            // 
            this.pbxHero3.Location = new System.Drawing.Point(585, 115);
            this.pbxHero3.Name = "pbxHero3";
            this.pbxHero3.Size = new System.Drawing.Size(124, 113);
            this.pbxHero3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero3.TabIndex = 26;
            this.pbxHero3.TabStop = false;
            // 
            // pnlAffichageHero
            // 
            this.pnlAffichageHero.AutoScroll = true;
            this.pnlAffichageHero.Location = new System.Drawing.Point(12, 319);
            this.pnlAffichageHero.Name = "pnlAffichageHero";
            this.pnlAffichageHero.Size = new System.Drawing.Size(835, 640);
            this.pnlAffichageHero.TabIndex = 36;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(388, 260);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 53);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Rénitialiser les héros";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SelectionHeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pnlAffichageHero);
            this.Controls.Add(this.pbxHero3);
            this.Controls.Add(this.pbxHero2);
            this.Controls.Add(this.pbxHero1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbxNomCampagnie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectionHeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "la";
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNomCampagnie;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.PictureBox pbxHero1;
        private System.Windows.Forms.PictureBox pbxHero2;
        private System.Windows.Forms.PictureBox pbxHero3;
        private System.Windows.Forms.Panel pnlAffichageHero;
        private System.Windows.Forms.Button btnReset;
    }
}