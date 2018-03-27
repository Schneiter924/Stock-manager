namespace Stock_manager
{
    partial class frmConfig
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
            this.lblServeur = new System.Windows.Forms.Label();
            this.lblBaseDonnee = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblMotPasse = new System.Windows.Forms.Label();
            this.txtServeur = new System.Windows.Forms.TextBox();
            this.txtBaseDonnee = new System.Windows.Forms.TextBox();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.txtMotPasse = new System.Windows.Forms.TextBox();
            this.cmdParDefaut = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.cmdAppliquer = new System.Windows.Forms.Button();
            this.cmdTestConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblServeur
            // 
            this.lblServeur.AutoSize = true;
            this.lblServeur.Location = new System.Drawing.Point(12, 21);
            this.lblServeur.Name = "lblServeur";
            this.lblServeur.Size = new System.Drawing.Size(257, 13);
            this.lblServeur.TabIndex = 0;
            this.lblServeur.Text = "IP ou nom du serveur qui contient la base de donnée";
            // 
            // lblBaseDonnee
            // 
            this.lblBaseDonnee.AutoSize = true;
            this.lblBaseDonnee.Location = new System.Drawing.Point(12, 51);
            this.lblBaseDonnee.Name = "lblBaseDonnee";
            this.lblBaseDonnee.Size = new System.Drawing.Size(135, 13);
            this.lblBaseDonnee.TabIndex = 1;
            this.lblBaseDonnee.Text = "Nom de la base de donnée";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(12, 77);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(95, 13);
            this.lblUtilisateur.TabIndex = 2;
            this.lblUtilisateur.Text = "Nom de l\'utilisateur";
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Location = new System.Drawing.Point(12, 107);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(149, 13);
            this.lblMotPasse.TabIndex = 3;
            this.lblMotPasse.Text = "Mot de passe de la connexion";
            // 
            // txtServeur
            // 
            this.txtServeur.Location = new System.Drawing.Point(286, 18);
            this.txtServeur.Name = "txtServeur";
            this.txtServeur.Size = new System.Drawing.Size(184, 20);
            this.txtServeur.TabIndex = 4;
            // 
            // txtBaseDonnee
            // 
            this.txtBaseDonnee.Location = new System.Drawing.Point(286, 48);
            this.txtBaseDonnee.Name = "txtBaseDonnee";
            this.txtBaseDonnee.Size = new System.Drawing.Size(184, 20);
            this.txtBaseDonnee.TabIndex = 5;
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(286, 74);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(184, 20);
            this.txtUtilisateur.TabIndex = 6;
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Location = new System.Drawing.Point(286, 104);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.PasswordChar = '*';
            this.txtMotPasse.Size = new System.Drawing.Size(184, 20);
            this.txtMotPasse.TabIndex = 7;
            // 
            // cmdParDefaut
            // 
            this.cmdParDefaut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdParDefaut.Location = new System.Drawing.Point(233, 155);
            this.cmdParDefaut.Name = "cmdParDefaut";
            this.cmdParDefaut.Size = new System.Drawing.Size(75, 23);
            this.cmdParDefaut.TabIndex = 8;
            this.cmdParDefaut.Text = "Par défaut";
            this.cmdParDefaut.UseVisualStyleBackColor = true;
            this.cmdParDefaut.Click += new System.EventHandler(this.cmdParDefaut_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdRetour.Location = new System.Drawing.Point(314, 155);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 9;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // cmdAppliquer
            // 
            this.cmdAppliquer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAppliquer.Location = new System.Drawing.Point(395, 155);
            this.cmdAppliquer.Name = "cmdAppliquer";
            this.cmdAppliquer.Size = new System.Drawing.Size(75, 23);
            this.cmdAppliquer.TabIndex = 10;
            this.cmdAppliquer.Text = "Appliquer";
            this.cmdAppliquer.UseVisualStyleBackColor = true;
            this.cmdAppliquer.Click += new System.EventHandler(this.cmdAppliquer_Click);
            // 
            // cmdTestConnexion
            // 
            this.cmdTestConnexion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdTestConnexion.Location = new System.Drawing.Point(109, 155);
            this.cmdTestConnexion.Name = "cmdTestConnexion";
            this.cmdTestConnexion.Size = new System.Drawing.Size(118, 23);
            this.cmdTestConnexion.TabIndex = 11;
            this.cmdTestConnexion.Text = "Test de la connexion";
            this.cmdTestConnexion.UseVisualStyleBackColor = true;
            this.cmdTestConnexion.Click += new System.EventHandler(this.cmdTestConnexion_Click);
            // 
            // frmConfig
            // 
            this.AcceptButton = this.cmdAppliquer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdRetour;
            this.ClientSize = new System.Drawing.Size(482, 190);
            this.Controls.Add(this.cmdTestConnexion);
            this.Controls.Add(this.cmdAppliquer);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdParDefaut);
            this.Controls.Add(this.txtMotPasse);
            this.Controls.Add(this.txtUtilisateur);
            this.Controls.Add(this.txtBaseDonnee);
            this.Controls.Add(this.txtServeur);
            this.Controls.Add(this.lblMotPasse);
            this.Controls.Add(this.lblUtilisateur);
            this.Controls.Add(this.lblBaseDonnee);
            this.Controls.Add(this.lblServeur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration de la connexion à la base de donnée";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConfig_FormClosed);
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServeur;
        private System.Windows.Forms.Label lblBaseDonnee;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Label lblMotPasse;
        private System.Windows.Forms.TextBox txtServeur;
        private System.Windows.Forms.TextBox txtBaseDonnee;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.TextBox txtMotPasse;
        private System.Windows.Forms.Button cmdParDefaut;
        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.Button cmdAppliquer;
        private System.Windows.Forms.Button cmdTestConnexion;
    }
}