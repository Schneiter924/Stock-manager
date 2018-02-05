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
            this.cmdEntree = new System.Windows.Forms.Button();
            this.cmdSortie = new System.Windows.Forms.Button();
            this.cmdRecherche = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
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
            // 
            // cmdEntree
            // 
            this.cmdEntree.Location = new System.Drawing.Point(12, 41);
            this.cmdEntree.Name = "cmdEntree";
            this.cmdEntree.Size = new System.Drawing.Size(137, 23);
            this.cmdEntree.TabIndex = 1;
            this.cmdEntree.Text = "Entrée de la pièce";
            this.cmdEntree.UseVisualStyleBackColor = true;
            // 
            // cmdSortie
            // 
            this.cmdSortie.Location = new System.Drawing.Point(12, 70);
            this.cmdSortie.Name = "cmdSortie";
            this.cmdSortie.Size = new System.Drawing.Size(137, 23);
            this.cmdSortie.TabIndex = 2;
            this.cmdSortie.Text = "Sortie de la pièce";
            this.cmdSortie.UseVisualStyleBackColor = true;
            // 
            // cmdRecherche
            // 
            this.cmdRecherche.Location = new System.Drawing.Point(12, 99);
            this.cmdRecherche.Name = "cmdRecherche";
            this.cmdRecherche.Size = new System.Drawing.Size(137, 23);
            this.cmdRecherche.TabIndex = 3;
            this.cmdRecherche.Text = "Recherche de pièce";
            this.cmdRecherche.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(12, 128);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(137, 23);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 188);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdRecherche);
            this.Controls.Add(this.cmdSortie);
            this.Controls.Add(this.cmdEntree);
            this.Controls.Add(this.cmdInventaire);
            this.Name = "frmMain";
            this.Text = "Stock manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdInventaire;
        private System.Windows.Forms.Button cmdEntree;
        private System.Windows.Forms.Button cmdSortie;
        private System.Windows.Forms.Button cmdRecherche;
        private System.Windows.Forms.Button cmdQuitter;
    }
}