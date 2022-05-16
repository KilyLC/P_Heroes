namespace P_Heroes
{
    partial class EcranChargement
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
            this.components = new System.ComponentModel.Container();
            this.pbrChargement = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrChargement = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbrChargement
            // 
            this.pbrChargement.BackColor = System.Drawing.Color.Red;
            this.pbrChargement.ForeColor = System.Drawing.Color.Yellow;
            this.pbrChargement.Location = new System.Drawing.Point(314, 940);
            this.pbrChargement.MarqueeAnimationSpeed = 1;
            this.pbrChargement.Name = "pbrChargement";
            this.pbrChargement.Size = new System.Drawing.Size(493, 34);
            this.pbrChargement.Step = 1;
            this.pbrChargement.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbrChargement.TabIndex = 0;
            this.pbrChargement.Click += new System.EventHandler(this.pbrChargement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(494, 902);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chargement : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrChargement
            // 
            this.tmrChargement.Enabled = true;
            this.tmrChargement.Interval = 1000;
            this.tmrChargement.Tick += new System.EventHandler(this.tmrChargement_Tick);
            // 
            // EcranChargement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::P_Heroes.Properties.Resources.EcranChargement;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbrChargement);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranChargement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chargement";
            this.Load += new System.EventHandler(this.EcranChargement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbrChargement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrChargement;
    }
}