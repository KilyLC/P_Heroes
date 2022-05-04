namespace P_Heroes
{
    partial class FormBoutique
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
            this.lblArgent = new System.Windows.Forms.Label();
            this.tctrlBoutique.SuspendLayout();
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
            this.tpgVendre.Location = new System.Drawing.Point(4, 22);
            this.tpgVendre.Name = "tpgVendre";
            this.tpgVendre.Padding = new System.Windows.Forms.Padding(3);
            this.tpgVendre.Size = new System.Drawing.Size(792, 394);
            this.tpgVendre.TabIndex = 1;
            this.tpgVendre.Text = "Vendre";
            this.tpgVendre.UseVisualStyleBackColor = true;
            // 
            // lblArgent
            // 
            this.lblArgent.AutoSize = true;
            this.lblArgent.Location = new System.Drawing.Point(12, 9);
            this.lblArgent.Name = "lblArgent";
            this.lblArgent.Size = new System.Drawing.Size(38, 13);
            this.lblArgent.TabIndex = 0;
            this.lblArgent.Text = "Argent";
            // 
            // FormBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArgent);
            this.Controls.Add(this.tctrlBoutique);
            this.Name = "FormBoutique";
            this.Text = "FormBoutique";
            this.tctrlBoutique.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlBoutique;
        private System.Windows.Forms.TabPage tpgAcheter;
        private System.Windows.Forms.TabPage tpgVendre;
        private System.Windows.Forms.Label lblArgent;
    }
}