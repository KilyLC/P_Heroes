namespace P_Heroes
{
    partial class Accueil
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnJouer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hsbVolume = new System.Windows.Forms.HScrollBar();
            this.lblNbVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(590, 145);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(205, 128);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnJouer
            // 
            this.btnJouer.Location = new System.Drawing.Point(271, 145);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(205, 128);
            this.btnJouer.TabIndex = 3;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume musique";
            // 
            // hsbVolume
            // 
            this.hsbVolume.LargeChange = 1;
            this.hsbVolume.Location = new System.Drawing.Point(398, 516);
            this.hsbVolume.Name = "hsbVolume";
            this.hsbVolume.Size = new System.Drawing.Size(235, 27);
            this.hsbVolume.TabIndex = 8;
            this.hsbVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbVolume_Scroll);
            // 
            // lblNbVolume
            // 
            this.lblNbVolume.AutoSize = true;
            this.lblNbVolume.Location = new System.Drawing.Point(493, 552);
            this.lblNbVolume.Name = "lblNbVolume";
            this.lblNbVolume.Size = new System.Drawing.Size(35, 13);
            this.lblNbVolume.TabIndex = 9;
            this.lblNbVolume.Text = "label2";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.lblNbVolume);
            this.Controls.Add(this.hsbVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.btnQuitter);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hsbVolume;
        private System.Windows.Forms.Label lblNbVolume;
    }
}