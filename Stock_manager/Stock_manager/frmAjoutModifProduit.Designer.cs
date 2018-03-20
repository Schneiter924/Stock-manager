namespace Stock_manager
{
    partial class frmAjoutModifProduit
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtNomProduit = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdAjout = new System.Windows.Forms.Button();
            this.cboIDProduit = new System.Windows.Forms.ComboBox();
            this.lblNombreCaractere = new System.Windows.Forms.Label();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(14, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(94, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numéro du produit";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(14, 55);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom du produit";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 153);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(110, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description du produit";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomProduit
            // 
            this.txtNomProduit.Location = new System.Drawing.Point(157, 52);
            this.txtNomProduit.Name = "txtNomProduit";
            this.txtNomProduit.Size = new System.Drawing.Size(179, 20);
            this.txtNomProduit.TabIndex = 4;
            this.txtNomProduit.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(157, 111);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(179, 88);
            this.txtDescription.TabIndex = 5;
            // 
            // cmdRetour
            // 
            this.cmdRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdRetour.Location = new System.Drawing.Point(99, 205);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 6;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // cmdAjout
            // 
            this.cmdAjout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAjout.Location = new System.Drawing.Point(261, 205);
            this.cmdAjout.Name = "cmdAjout";
            this.cmdAjout.Size = new System.Drawing.Size(75, 23);
            this.cmdAjout.TabIndex = 7;
            this.cmdAjout.Text = "Ajouter";
            this.cmdAjout.UseVisualStyleBackColor = true;
            this.cmdAjout.Click += new System.EventHandler(this.cmdAjout_Click);
            // 
            // cboIDProduit
            // 
            this.cboIDProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboIDProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboIDProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDProduit.FormattingEnabled = true;
            this.cboIDProduit.Location = new System.Drawing.Point(157, 12);
            this.cboIDProduit.Name = "cboIDProduit";
            this.cboIDProduit.Size = new System.Drawing.Size(179, 21);
            this.cboIDProduit.TabIndex = 3;
            this.cboIDProduit.SelectedIndexChanged += new System.EventHandler(this.cboIDPiece_SelectedIndexChanged);
            // 
            // lblNombreCaractere
            // 
            this.lblNombreCaractere.AutoSize = true;
            this.lblNombreCaractere.Location = new System.Drawing.Point(14, 85);
            this.lblNombreCaractere.Name = "lblNombreCaractere";
            this.lblNombreCaractere.Size = new System.Drawing.Size(307, 13);
            this.lblNombreCaractere.TabIndex = 10;
            this.lblNombreCaractere.Text = "Nombre de caractère actuelle 0 / nombre de caractères max 45";
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(180, 205);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 11;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // frmAjoutModifProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdRetour;
            this.ClientSize = new System.Drawing.Size(348, 249);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.lblNombreCaractere);
            this.Controls.Add(this.cboIDProduit);
            this.Controls.Add(this.cmdAjout);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNomProduit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjoutModifProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout et modification de produit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEntree_FormClosed);
            this.Load += new System.EventHandler(this.frmEntree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtNomProduit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdAjout;
        private System.Windows.Forms.ComboBox cboIDProduit;
        private System.Windows.Forms.Label lblNombreCaractere;
        private System.Windows.Forms.Button cmdSupprimer;
    }
}