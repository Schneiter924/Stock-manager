namespace Stock_manager
{
    partial class frmReMot
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
            this.lstRecherche = new System.Windows.Forms.ListBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.cmdChercher = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstRecherche
            // 
            this.lstRecherche.FormattingEnabled = true;
            this.lstRecherche.Location = new System.Drawing.Point(12, 40);
            this.lstRecherche.Name = "lstRecherche";
            this.lstRecherche.Size = new System.Drawing.Size(937, 537);
            this.lstRecherche.TabIndex = 0;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(12, 9);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(79, 13);
            this.lblRecherche.TabIndex = 1;
            this.lblRecherche.Text = "Mot à chercher";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(122, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(151, 20);
            this.txtRecherche.TabIndex = 2;
            // 
            // cmdChercher
            // 
            this.cmdChercher.Location = new System.Drawing.Point(294, 4);
            this.cmdChercher.Name = "cmdChercher";
            this.cmdChercher.Size = new System.Drawing.Size(75, 23);
            this.cmdChercher.TabIndex = 3;
            this.cmdChercher.Text = "Chercher";
            this.cmdChercher.UseVisualStyleBackColor = true;
            this.cmdChercher.Click += new System.EventHandler(this.cmdChercher_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(375, 4);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 4;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // frmReMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 591);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdChercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lstRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche mot-clé";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReMot_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button cmdChercher;
        private System.Windows.Forms.Button cmdRetour;
    }
}