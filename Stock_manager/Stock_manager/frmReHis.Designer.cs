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
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lstRecherche = new System.Windows.Forms.ListBox();
            this.cboProduit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdRetour.Location = new System.Drawing.Point(375, 4);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 9;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // cmdChercher
            // 
            this.cmdChercher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdChercher.Location = new System.Drawing.Point(294, 4);
            this.cmdChercher.Name = "cmdChercher";
            this.cmdChercher.Size = new System.Drawing.Size(75, 23);
            this.cmdChercher.TabIndex = 5;
            this.cmdChercher.Text = "Chercher";
            this.cmdChercher.UseVisualStyleBackColor = true;
            this.cmdChercher.Click += new System.EventHandler(this.cmdChercher_Click);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(12, 9);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(94, 13);
            this.lblRecherche.TabIndex = 6;
            this.lblRecherche.Text = "Numéro du produit";
            // 
            // lstRecherche
            // 
            this.lstRecherche.FormattingEnabled = true;
            this.lstRecherche.HorizontalScrollbar = true;
            this.lstRecherche.Location = new System.Drawing.Point(15, 33);
            this.lstRecherche.Name = "lstRecherche";
            this.lstRecherche.Size = new System.Drawing.Size(943, 524);
            this.lstRecherche.TabIndex = 10;
            // 
            // cboProduit
            // 
            this.cboProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduit.FormattingEnabled = true;
            this.cboProduit.Location = new System.Drawing.Point(128, 6);
            this.cboProduit.Name = "cboProduit";
            this.cboProduit.Size = new System.Drawing.Size(145, 21);
            this.cboProduit.TabIndex = 4;
            // 
            // frmReHis
            // 
            this.AcceptButton = this.cmdChercher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdRetour;
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.cboProduit);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdChercher);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lstRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReHis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche historique";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReHis_FormClosed);
            this.Load += new System.EventHandler(this.frmReHis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdChercher;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.ListBox lstRecherche;
        private System.Windows.Forms.ComboBox cboProduit;
    }
}