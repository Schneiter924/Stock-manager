namespace Stock_manager
{
    partial class frmMenu
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
            this.cmdInventaire = new System.Windows.Forms.Button();
            this.cmdAMProduit = new System.Windows.Forms.Button();
            this.cmdLocation = new System.Windows.Forms.Button();
            this.cmdMenuRecherche = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdRetourPrduit = new System.Windows.Forms.Button();
            this.cmdLoueur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdInventaire
            // 
            this.cmdInventaire.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdInventaire.Location = new System.Drawing.Point(12, 12);
            this.cmdInventaire.Name = "cmdInventaire";
            this.cmdInventaire.Size = new System.Drawing.Size(192, 23);
            this.cmdInventaire.TabIndex = 0;
            this.cmdInventaire.Text = "Voir l\'inventaire";
            this.cmdInventaire.UseVisualStyleBackColor = true;
            this.cmdInventaire.Click += new System.EventHandler(this.cmdInventaire_Click);
            // 
            // cmdAMProduit
            // 
            this.cmdAMProduit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAMProduit.Location = new System.Drawing.Point(12, 41);
            this.cmdAMProduit.Name = "cmdAMProduit";
            this.cmdAMProduit.Size = new System.Drawing.Size(192, 23);
            this.cmdAMProduit.TabIndex = 1;
            this.cmdAMProduit.Text = "Ajout / modifé produit";
            this.cmdAMProduit.UseVisualStyleBackColor = true;
            this.cmdAMProduit.Click += new System.EventHandler(this.cmdAMProduit_Click);
            // 
            // cmdLocation
            // 
            this.cmdLocation.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdLocation.Location = new System.Drawing.Point(12, 99);
            this.cmdLocation.Name = "cmdLocation";
            this.cmdLocation.Size = new System.Drawing.Size(192, 23);
            this.cmdLocation.TabIndex = 4;
            this.cmdLocation.Text = "Location d\'un produit";
            this.cmdLocation.UseVisualStyleBackColor = true;
            this.cmdLocation.Click += new System.EventHandler(this.cmdLocation_Click);
            // 
            // cmdMenuRecherche
            // 
            this.cmdMenuRecherche.Location = new System.Drawing.Point(12, 157);
            this.cmdMenuRecherche.Name = "cmdMenuRecherche";
            this.cmdMenuRecherche.Size = new System.Drawing.Size(192, 23);
            this.cmdMenuRecherche.TabIndex = 6;
            this.cmdMenuRecherche.Text = "Affiche le menu pour la recherche";
            this.cmdMenuRecherche.UseVisualStyleBackColor = true;
            this.cmdMenuRecherche.Click += new System.EventHandler(this.cmdMenuRecherche_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdQuitter.Location = new System.Drawing.Point(12, 186);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(192, 23);
            this.cmdQuitter.TabIndex = 7;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdRetourPrduit
            // 
            this.cmdRetourPrduit.Location = new System.Drawing.Point(12, 128);
            this.cmdRetourPrduit.Name = "cmdRetourPrduit";
            this.cmdRetourPrduit.Size = new System.Drawing.Size(192, 23);
            this.cmdRetourPrduit.TabIndex = 5;
            this.cmdRetourPrduit.Text = "Retour d\'un produit";
            this.cmdRetourPrduit.UseVisualStyleBackColor = true;
            this.cmdRetourPrduit.Click += new System.EventHandler(this.cmdRetourPrduit_Click);
            // 
            // cmdLoueur
            // 
            this.cmdLoueur.Location = new System.Drawing.Point(12, 70);
            this.cmdLoueur.Name = "cmdLoueur";
            this.cmdLoueur.Size = new System.Drawing.Size(192, 23);
            this.cmdLoueur.TabIndex = 3;
            this.cmdLoueur.Text = "Ajout / modifié loueur";
            this.cmdLoueur.UseVisualStyleBackColor = true;
            this.cmdLoueur.Click += new System.EventHandler(this.cmdLoueur_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdQuitter;
            this.ClientSize = new System.Drawing.Size(230, 225);
            this.Controls.Add(this.cmdLoueur);
            this.Controls.Add(this.cmdRetourPrduit);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdMenuRecherche);
            this.Controls.Add(this.cmdLocation);
            this.Controls.Add(this.cmdAMProduit);
            this.Controls.Add(this.cmdInventaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInventaire;
        private System.Windows.Forms.Button cmdAMProduit;
        private System.Windows.Forms.Button cmdLocation;
        private System.Windows.Forms.Button cmdMenuRecherche;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdRetourPrduit;
        private System.Windows.Forms.Button cmdLoueur;
    }
}