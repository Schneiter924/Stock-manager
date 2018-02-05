namespace Stock_manager
{
    partial class frmInventaire
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
            this.lstInventaire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(277, 237);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 7;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            // 
            // lstInventaire
            // 
            this.lstInventaire.FormattingEnabled = true;
            this.lstInventaire.Location = new System.Drawing.Point(12, 12);
            this.lstInventaire.Name = "lstInventaire";
            this.lstInventaire.Size = new System.Drawing.Size(246, 251);
            this.lstInventaire.TabIndex = 8;
            // 
            // frmInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 272);
            this.Controls.Add(this.lstInventaire);
            this.Controls.Add(this.cmdRetour);
            this.Name = "frmInventaire";
            this.Text = "Inventaire";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.ListBox lstInventaire;
    }
}