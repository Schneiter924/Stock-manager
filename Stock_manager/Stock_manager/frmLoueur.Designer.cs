namespace Stock_manager
{
    partial class frmLoueur
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
            this.txtNomLoueur = new System.Windows.Forms.TextBox();
            this.lblNomLoueur = new System.Windows.Forms.Label();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.lblNombreCaractere = new System.Windows.Forms.Label();
            this.cmdAjoutModification = new System.Windows.Forms.Button();
            this.lblIDLoueur = new System.Windows.Forms.Label();
            this.cboIDLoueur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNomLoueur
            // 
            this.txtNomLoueur.Location = new System.Drawing.Point(117, 62);
            this.txtNomLoueur.Name = "txtNomLoueur";
            this.txtNomLoueur.Size = new System.Drawing.Size(206, 20);
            this.txtNomLoueur.TabIndex = 2;
            this.txtNomLoueur.TextChanged += new System.EventHandler(this.txtNomLoueur_TextChanged);
            // 
            // lblNomLoueur
            // 
            this.lblNomLoueur.AutoSize = true;
            this.lblNomLoueur.Location = new System.Drawing.Point(23, 65);
            this.lblNomLoueur.Name = "lblNomLoueur";
            this.lblNomLoueur.Size = new System.Drawing.Size(76, 13);
            this.lblNomLoueur.TabIndex = 1;
            this.lblNomLoueur.Text = "Nom du loueur";
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(169, 110);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 3;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // lblNombreCaractere
            // 
            this.lblNombreCaractere.AutoSize = true;
            this.lblNombreCaractere.Location = new System.Drawing.Point(21, 94);
            this.lblNombreCaractere.Name = "lblNombreCaractere";
            this.lblNombreCaractere.Size = new System.Drawing.Size(302, 13);
            this.lblNombreCaractere.TabIndex = 9;
            this.lblNombreCaractere.Text = "Nombre de caractère actuelle 0 / nombre de caractère max 45";
            // 
            // cmdAjoutModification
            // 
            this.cmdAjoutModification.Location = new System.Drawing.Point(250, 110);
            this.cmdAjoutModification.Name = "cmdAjoutModification";
            this.cmdAjoutModification.Size = new System.Drawing.Size(75, 23);
            this.cmdAjoutModification.TabIndex = 4;
            this.cmdAjoutModification.Text = "Ajouter";
            this.cmdAjoutModification.UseVisualStyleBackColor = true;
            this.cmdAjoutModification.Click += new System.EventHandler(this.cmdAjoutModification_Click);
            // 
            // lblIDLoueur
            // 
            this.lblIDLoueur.AutoSize = true;
            this.lblIDLoueur.Location = new System.Drawing.Point(23, 32);
            this.lblIDLoueur.Name = "lblIDLoueur";
            this.lblIDLoueur.Size = new System.Drawing.Size(76, 13);
            this.lblIDLoueur.TabIndex = 10;
            this.lblIDLoueur.Text = "Nom du loueur";
            // 
            // cboIDLoueur
            // 
            this.cboIDLoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIDLoueur.FormattingEnabled = true;
            this.cboIDLoueur.Location = new System.Drawing.Point(117, 29);
            this.cboIDLoueur.Name = "cboIDLoueur";
            this.cboIDLoueur.Size = new System.Drawing.Size(206, 21);
            this.cboIDLoueur.TabIndex = 1;
            // 
            // frmLoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 145);
            this.Controls.Add(this.cboIDLoueur);
            this.Controls.Add(this.lblIDLoueur);
            this.Controls.Add(this.cmdAjoutModification);
            this.Controls.Add(this.lblNombreCaractere);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.lblNomLoueur);
            this.Controls.Add(this.txtNomLoueur);
            this.Name = "frmLoueur";
            this.Text = "Ajoute / modification loueur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLoueur_FormClosed);
            this.Load += new System.EventHandler(this.frmLoueur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomLoueur;
        private System.Windows.Forms.Label lblNomLoueur;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Label lblNombreCaractere;
        private System.Windows.Forms.Button cmdAjoutModification;
        private System.Windows.Forms.Label lblIDLoueur;
        private System.Windows.Forms.ComboBox cboIDLoueur;
    }
}