namespace Stock_manager
{
    partial class frmSortie
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
            this.cmdAjout = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.lblLoueur = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtDateRetour = new System.Windows.Forms.TextBox();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.cboProduit = new System.Windows.Forms.ComboBox();
            this.cboLoueur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdAjout
            // 
            this.cmdAjout.Location = new System.Drawing.Point(197, 183);
            this.cmdAjout.Name = "cmdAjout";
            this.cmdAjout.Size = new System.Drawing.Size(75, 23);
            this.cmdAjout.TabIndex = 4;
            this.cmdAjout.Text = "Ajouter";
            this.cmdAjout.UseVisualStyleBackColor = true;
            this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(116, 183);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 3;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(161, 69);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.ReadOnly = true;
            this.txtDuree.Size = new System.Drawing.Size(115, 20);
            this.txtDuree.TabIndex = 12;
            // 
            // lblLoueur
            // 
            this.lblLoueur.AutoSize = true;
            this.lblLoueur.Location = new System.Drawing.Point(18, 145);
            this.lblLoueur.Name = "lblLoueur";
            this.lblLoueur.Size = new System.Drawing.Size(76, 13);
            this.lblLoueur.TabIndex = 10;
            this.lblLoueur.Text = "Nom du loueur";
            this.lblLoueur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(18, 72);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(102, 13);
            this.lblDuree.TabIndex = 9;
            this.lblDuree.Text = "Durée de la location";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(18, 35);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(99, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Numéro de la pièce";
            // 
            // txtDateRetour
            // 
            this.txtDateRetour.Location = new System.Drawing.Point(161, 106);
            this.txtDateRetour.Name = "txtDateRetour";
            this.txtDateRetour.ReadOnly = true;
            this.txtDateRetour.Size = new System.Drawing.Size(115, 20);
            this.txtDateRetour.TabIndex = 17;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Location = new System.Drawing.Point(18, 109);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(75, 13);
            this.lblDateRetour.TabIndex = 16;
            this.lblDateRetour.Text = "Date de retour";
            // 
            // cboProduit
            // 
            this.cboProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduit.FormattingEnabled = true;
            this.cboProduit.Location = new System.Drawing.Point(161, 32);
            this.cboProduit.Name = "cboProduit";
            this.cboProduit.Size = new System.Drawing.Size(115, 21);
            this.cboProduit.TabIndex = 1;
            // 
            // cboLoueur
            // 
            this.cboLoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoueur.FormattingEnabled = true;
            this.cboLoueur.Location = new System.Drawing.Point(161, 145);
            this.cboLoueur.Name = "cboLoueur";
            this.cboLoueur.Size = new System.Drawing.Size(115, 21);
            this.cboLoueur.TabIndex = 2;
            this.cboLoueur.Validated += new System.EventHandler(this.cboLoueur_Validated);
            // 
            // frmSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.cboLoueur);
            this.Controls.Add(this.cboProduit);
            this.Controls.Add(this.txtDateRetour);
            this.Controls.Add(this.lblDateRetour);
            this.Controls.Add(this.cmdAjout);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.lblLoueur);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sortie du stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSortie_FormClosed);
            this.Load += new System.EventHandler(this.frmSortie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAjout;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label lblLoueur;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtDateRetour;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.ComboBox cboProduit;
        private System.Windows.Forms.ComboBox cboLoueur;
    }
}