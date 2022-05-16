namespace P_Heroes.Model
{
    partial class FormPlus
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.pbxMiniature = new System.Windows.Forms.PictureBox();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblTitreDescription = new System.Windows.Forms.Label();
            this.lblTitreStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(217, 58);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            // 
            // pbxMiniature
            // 
            this.pbxMiniature.Location = new System.Drawing.Point(235, 12);
            this.pbxMiniature.Name = "pbxMiniature";
            this.pbxMiniature.Size = new System.Drawing.Size(237, 237);
            this.pbxMiniature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMiniature.TabIndex = 1;
            this.pbxMiniature.TabStop = false;
            // 
            // lblStats
            // 
            this.lblStats.Location = new System.Drawing.Point(12, 154);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(217, 95);
            this.lblStats.TabIndex = 2;
            this.lblStats.Text = "Stats";
            // 
            // lblTitreDescription
            // 
            this.lblTitreDescription.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreDescription.Location = new System.Drawing.Point(12, 9);
            this.lblTitreDescription.Name = "lblTitreDescription";
            this.lblTitreDescription.Size = new System.Drawing.Size(217, 42);
            this.lblTitreDescription.TabIndex = 3;
            this.lblTitreDescription.Text = "Description";
            this.lblTitreDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitreStats
            // 
            this.lblTitreStats.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreStats.Location = new System.Drawing.Point(12, 112);
            this.lblTitreStats.Name = "lblTitreStats";
            this.lblTitreStats.Size = new System.Drawing.Size(217, 42);
            this.lblTitreStats.TabIndex = 4;
            this.lblTitreStats.Text = "Stats";
            this.lblTitreStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lblTitreStats);
            this.Controls.Add(this.lblTitreDescription);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.pbxMiniature);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plus";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiniature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pbxMiniature;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblTitreDescription;
        private System.Windows.Forms.Label lblTitreStats;
    }
}