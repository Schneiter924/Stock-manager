namespace Stock_manager
{
    partial class frmReHors
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
            this.lstRecherche = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(12, 599);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 11;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // lstRecherche
            // 
            this.lstRecherche.FormattingEnabled = true;
            this.lstRecherche.Location = new System.Drawing.Point(11, 12);
            this.lstRecherche.Name = "lstRecherche";
            this.lstRecherche.Size = new System.Drawing.Size(1017, 576);
            this.lstRecherche.TabIndex = 10;
            // 
            // frmReHors
            // 
            this.AcceptButton = this.cmdRetour;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 634);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.lstRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReHors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher hors-délai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReHors_FormClosed);
            this.Load += new System.EventHandler(this.frmReHors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.ListBox lstRecherche;
    }
}