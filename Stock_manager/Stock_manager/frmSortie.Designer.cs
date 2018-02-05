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
            this.txtLoueur = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLoueur = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAjout
            // 
            this.cmdAjout.Location = new System.Drawing.Point(197, 158);
            this.cmdAjout.Name = "cmdAjout";
            this.cmdAjout.Size = new System.Drawing.Size(75, 23);
            this.cmdAjout.TabIndex = 15;
            this.cmdAjout.Text = "Ajouter";
            this.cmdAjout.UseVisualStyleBackColor = true;
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(116, 158);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 14;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // txtLoueur
            // 
            this.txtLoueur.Enabled = false;
            this.txtLoueur.Location = new System.Drawing.Point(161, 104);
            this.txtLoueur.Name = "txtLoueur";
            this.txtLoueur.Size = new System.Drawing.Size(115, 20);
            this.txtLoueur.TabIndex = 13;
            // 
            // txtDuree
            // 
            this.txtDuree.Enabled = false;
            this.txtDuree.Location = new System.Drawing.Point(161, 69);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(115, 20);
            this.txtDuree.TabIndex = 12;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(161, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // lblLoueur
            // 
            this.lblLoueur.AutoSize = true;
            this.lblLoueur.Enabled = false;
            this.lblLoueur.Location = new System.Drawing.Point(18, 107);
            this.lblLoueur.Name = "lblLoueur";
            this.lblLoueur.Size = new System.Drawing.Size(76, 13);
            this.lblLoueur.TabIndex = 10;
            this.lblLoueur.Text = "Nom du loueur";
            this.lblLoueur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Enabled = false;
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
            // frmSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.cmdAjout);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.txtLoueur);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblLoueur);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblNumero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSortie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAjout;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.TextBox txtLoueur;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblLoueur;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblNumero;
    }
}