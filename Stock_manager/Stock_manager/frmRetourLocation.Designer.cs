namespace Stock_manager
{
    partial class frmRetourLocation
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
            this.cboProduit = new System.Windows.Forms.ComboBox();
            this.cmdRetourProduit = new System.Windows.Forms.Button();
            this.cmdRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRetour
            // 
            this.lblRetour.AutoSize = true;
            this.lblRetour.Location = new System.Drawing.Point(11, 15);
            this.lblRetour.Name = "lblRetour";
            this.lblRetour.Size = new System.Drawing.Size(144, 13);
            this.lblRetour.TabIndex = 0;
            this.lblRetour.Text = "Liste des produits en location";
            // 
            // cboProduit
            // 
            this.cboProduit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProduit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProduit.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduit.FormattingEnabled = true;
            this.cboProduit.Location = new System.Drawing.Point(161, 12);
            this.cboProduit.Name = "cboProduit";
            this.cboProduit.Size = new System.Drawing.Size(108, 21);
            this.cboProduit.TabIndex = 1;
            // 
            // cmdRetourProduit
            // 
            this.cmdRetourProduit.Location = new System.Drawing.Point(161, 60);
            this.cmdRetourProduit.Name = "cmdRetourProduit";
            this.cmdRetourProduit.Size = new System.Drawing.Size(108, 23);
            this.cmdRetourProduit.TabIndex = 2;
            this.cmdRetourProduit.Text = "Retour du produit";
            this.cmdRetourProduit.UseVisualStyleBackColor = true;
            this.cmdRetourProduit.Click += new System.EventHandler(this.cmdRetourPiece_Click);
            // 
            // cmdRetour
            // 
            this.cmdRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdRetour.Location = new System.Drawing.Point(80, 60);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 3;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // frmRetourLocation
            // 
            this.AcceptButton = this.cmdRetourProduit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdRetour;
            this.ClientSize = new System.Drawing.Size(272, 102);
            this.Controls.Add(this.cmdRetour);
            this.Controls.Add(this.cmdRetourProduit);
            this.Controls.Add(this.cboProduit);
            this.Controls.Add(this.lblRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRetourLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retour du produit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRetourPiece_FormClosed);
            this.Load += new System.EventHandler(this.frmRetourPiece_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetour;
        private System.Windows.Forms.ComboBox cboProduit;
        private System.Windows.Forms.Button cmdRetourProduit;
        private System.Windows.Forms.Button cmdRetour;
    }
}