namespace Stock_manager
{
    partial class frmRetourPiece
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
            this.lblRetour = new System.Windows.Forms.Label();
            this.cboPiece = new System.Windows.Forms.ComboBox();
            this.cmdRetourPiece = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Location = new System.Drawing.Point(25, 52);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(112, 13);
            this.lblRetour.TabIndex = 0;
            this.lblRetour.Text = "liste des pièces sorties";
            // 
            // cboPiece
            // 
            this.cboPiece.FormattingEnabled = true;
            this.cboPiece.Location = new System.Drawing.Point(145, 49);
            this.cboPiece.Name = "cboPiece";
            this.cboPiece.Size = new System.Drawing.Size(108, 21);
            this.cboPiece.TabIndex = 1;
            // 
            // cmdRetourPiece
            // 
            this.cmdRetourPiece.Location = new System.Drawing.Point(145, 97);
            this.cmdRetourPiece.Name = "cmdRetourPiece";
            this.cmdRetourPiece.Size = new System.Drawing.Size(108, 23);
            this.cmdRetourPiece.TabIndex = 2;
            this.cmdRetourPiece.Text = "Retour de la pièce";
            this.cmdRetourPiece.UseVisualStyleBackColor = true;
            this.cmdRetourPiece.Click += new System.EventHandler(this.cmdRetourPiece_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(64, 97);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 3;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // frmRetourPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 132);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdRetourPiece);
            this.Controls.Add(this.cboPiece);
            this.Controls.Add(this.lblRetour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRetourPiece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retour de la pièce";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRetourPiece_FormClosed);
            this.Load += new System.EventHandler(this.frmRetourPiece_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.ComboBox cboPiece;
        private System.Windows.Forms.Button cmdRetourPiece;
        private System.Windows.Forms.Button cmdRetour;
    }
}