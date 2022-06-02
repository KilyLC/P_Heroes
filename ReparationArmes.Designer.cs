namespace P_Heroes
{
    partial class ReparationArmes
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
            this.pnlAffichageArmes = new System.Windows.Forms.Panel();
            this.btnReparer = new System.Windows.Forms.Button();
            this.gbxArmeSelect = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPrixTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlAffichageArmes
            // 
            this.pnlAffichageArmes.AutoScroll = true;
            this.pnlAffichageArmes.Location = new System.Drawing.Point(12, 203);
            this.pnlAffichageArmes.Name = "pnlAffichageArmes";
            this.pnlAffichageArmes.Size = new System.Drawing.Size(1048, 794);
            this.pnlAffichageArmes.TabIndex = 0;
            // 
            // btnReparer
            // 
            this.btnReparer.Location = new System.Drawing.Point(871, 65);
            this.btnReparer.Name = "btnReparer";
            this.btnReparer.Size = new System.Drawing.Size(189, 58);
            this.btnReparer.TabIndex = 1;
            this.btnReparer.Text = "Réparer";
            this.btnReparer.UseVisualStyleBackColor = true;
            this.btnReparer.Click += new System.EventHandler(this.btnReparer_Click);
            // 
            // gbxArmeSelect
            // 
            this.gbxArmeSelect.Location = new System.Drawing.Point(35, 45);
            this.gbxArmeSelect.Name = "gbxArmeSelect";
            this.gbxArmeSelect.Size = new System.Drawing.Size(806, 128);
            this.gbxArmeSelect.TabIndex = 2;
            this.gbxArmeSelect.TabStop = false;
            this.gbxArmeSelect.Text = "Armes sélectionnés";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(868, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Prix Total :";
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.AutoSize = true;
            this.lblPrixTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixTotal.Location = new System.Drawing.Point(949, 45);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(17, 17);
            this.lblPrixTotal.TabIndex = 4;
            this.lblPrixTotal.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(871, 148);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 48);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Rénitialiser";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ReparationArmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 1009);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPrixTotal);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gbxArmeSelect);
            this.Controls.Add(this.btnReparer);
            this.Controls.Add(this.pnlAffichageArmes);
            this.Name = "ReparationArmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Réparation armes";
            this.Load += new System.EventHandler(this.ReparationArmes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAffichageArmes;
        private System.Windows.Forms.Button btnReparer;
        private System.Windows.Forms.GroupBox gbxArmeSelect;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPrixTotal;
        private System.Windows.Forms.Button btnReset;
    }
}