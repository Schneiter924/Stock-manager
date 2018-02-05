namespace Stock_manager
{
    partial class frmReHis
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
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdChercher = new System.Windows.Forms.Button();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lstRecherche = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(294, 227);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 9;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            // 
            // cmdChercher
            // 
            this.cmdChercher.Location = new System.Drawing.Point(294, 4);
            this.cmdChercher.Name = "cmdChercher";
            this.cmdChercher.Size = new System.Drawing.Size(75, 23);
            this.cmdChercher.TabIndex = 8;
            this.cmdChercher.Text = "Chercher";
            this.cmdChercher.UseVisualStyleBackColor = true;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(122, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(151, 20);
            this.txtRecherche.TabIndex = 7;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(12, 9);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(99, 13);
            this.lblRecherche.TabIndex = 6;
            this.lblRecherche.Text = "Numéro de la pièce";
            // 
            // lstRecherche
            // 
            this.lstRecherche.FormattingEnabled = true;
            this.lstRecherche.Location = new System.Drawing.Point(12, 40);
            this.lstRecherche.Name = "lstRecherche";
            this.lstRecherche.Size = new System.Drawing.Size(261, 212);
            this.lstRecherche.TabIndex = 5;
            // 
            // frmReHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 270);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdChercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lstRecherche);
            this.Name = "frmReHis";
            this.Text = "Recherche historique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdChercher;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.ListBox lstRecherche;
    }
}