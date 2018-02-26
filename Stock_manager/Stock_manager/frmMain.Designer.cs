namespace Stock_manager
{
    partial class frmMain
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
            this.cmdNouvellePiece = new System.Windows.Forms.Button();
            this.cmdSortie = new System.Windows.Forms.Button();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdRetourPièce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdInventaire
            // 
            this.cmdInventaire.Location = new System.Drawing.Point(12, 12);
            this.cmdInventaire.Name = "cmdInventaire";
            this.cmdInventaire.Size = new System.Drawing.Size(137, 23);
            this.cmdInventaire.TabIndex = 0;
            this.cmdInventaire.Text = "Voir l\'inventaire";
            this.cmdInventaire.UseVisualStyleBackColor = true;
            this.cmdInventaire.Click += new System.EventHandler(this.cmdInventaire_Click);
            // 
            // cmdNouvellePiece
            // 
            this.cmdNouvellePiece.Location = new System.Drawing.Point(12, 41);
            this.cmdNouvellePiece.Name = "cmdNouvellePiece";
            this.cmdNouvellePiece.Size = new System.Drawing.Size(137, 23);
            this.cmdNouvellePiece.TabIndex = 1;
            this.cmdNouvellePiece.Text = "Nouvelle pièce";
            this.cmdNouvellePiece.UseVisualStyleBackColor = true;
            this.cmdNouvellePiece.Click += new System.EventHandler(this.cmdNouvellePiece_Click);
            // 
            // cmdSortie
            // 
            this.cmdSortie.Location = new System.Drawing.Point(12, 99);
            this.cmdSortie.Name = "cmdSortie";
            this.cmdSortie.Size = new System.Drawing.Size(137, 23);
            this.cmdSortie.TabIndex = 4;
            this.cmdSortie.Text = "Sortie de la pièce";
            this.cmdSortie.UseVisualStyleBackColor = true;
            this.cmdSortie.Click += new System.EventHandler(this.cmdSortie_Click);
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Location = new System.Drawing.Point(12, 128);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(137, 23);
            this.cmdRecherche.TabIndex = 5;
            this.cmdRecherche.Text = "Recherche de pièce";
            this.cmdRecherche.UseVisualStyleBackColor = true;
            this.cmdRecherche.Click += new System.EventHandler(this.cmdRecherche_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(12, 157);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(137, 23);
            this.cmdQuitter.TabIndex = 6;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdRetourPièce
            // 
            this.cmdRetourPièce.Location = new System.Drawing.Point(12, 70);
            this.cmdRetourPièce.Name = "cmdRetourPièce";
            this.cmdRetourPièce.Size = new System.Drawing.Size(137, 23);
            this.cmdRetourPièce.TabIndex = 3;
            this.cmdRetourPièce.Text = "Retour de la pièce";
            this.cmdRetourPièce.UseVisualStyleBackColor = true;
            this.cmdRetourPièce.Click += new System.EventHandler(this.cmdRetourPièce_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 188);
            this.Controls.Add(this.cmdRetourPièce);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdRecherche);
            this.Controls.Add(this.cmdSortie);
            this.Controls.Add(this.cmdNouvellePiece);
            this.Controls.Add(this.cmdInventaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInventaire;
        private System.Windows.Forms.Button cmdNouvellePiece;
        private System.Windows.Forms.Button cmdSortie;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdRetourPièce;
    }
}