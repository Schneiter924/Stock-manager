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
            this.lstInventaireStock = new System.Windows.Forms.ListBox();
            this.lstInventaireLoue = new System.Windows.Forms.ListBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblProduitEnStockEtTotal = new System.Windows.Forms.Label();
            this.lblListeLocationTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRetour
            // 
            this.cmdRetour.Location = new System.Drawing.Point(12, 554);
            this.cmdRetour.Name = "cmdRetour";
            this.cmdRetour.Size = new System.Drawing.Size(75, 23);
            this.cmdRetour.TabIndex = 7;
            this.cmdRetour.Text = "Retour";
            this.cmdRetour.UseVisualStyleBackColor = true;
            this.cmdRetour.Click += new System.EventHandler(this.cmdRetour_Click);
            // 
            // lstInventaireStock
            // 
            this.lstInventaireStock.FormattingEnabled = true;
            this.lstInventaireStock.Location = new System.Drawing.Point(12, 27);
            this.lstInventaireStock.Name = "lstInventaireStock";
            this.lstInventaireStock.Size = new System.Drawing.Size(594, 251);
            this.lstInventaireStock.TabIndex = 8;
            // 
            // lstInventaireLoue
            // 
            this.lstInventaireLoue.FormattingEnabled = true;
            this.lstInventaireLoue.Location = new System.Drawing.Point(12, 297);
            this.lstInventaireLoue.Name = "lstInventaireLoue";
            this.lstInventaireLoue.Size = new System.Drawing.Size(594, 251);
            this.lstInventaireLoue.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(12, 9);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(84, 13);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Produit en stock";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(12, 281);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(95, 13);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Produit en location";
            // 
            // lblProduitEnStockEtTotal
            // 
            this.lblProduitEnStockEtTotal.AutoSize = true;
            this.lblProduitEnStockEtTotal.Location = new System.Drawing.Point(128, 9);
            this.lblProduitEnStockEtTotal.Name = "lblProduitEnStockEtTotal";
            this.lblProduitEnStockEtTotal.Size = new System.Drawing.Size(0, 13);
            this.lblProduitEnStockEtTotal.TabIndex = 12;
            // 
            // lblListeLocationTotal
            // 
            this.lblListeLocationTotal.AutoSize = true;
            this.lblListeLocationTotal.Location = new System.Drawing.Point(128, 281);
            this.lblListeLocationTotal.Name = "lblListeLocationTotal";
            this.lblListeLocationTotal.Size = new System.Drawing.Size(0, 13);
            this.lblListeLocationTotal.TabIndex = 13;
            // 
            // frmInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 583);
            this.Controls.Add(this.lblListeLocationTotal);
            this.Controls.Add(this.lblProduitEnStockEtTotal);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lstInventaireLoue);
            this.Controls.Add(this.lstInventaireStock);
            this.Controls.Add(this.cmdRetour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.frmInventaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRetour;
        private System.Windows.Forms.ListBox lstInventaireStock;
        private System.Windows.Forms.ListBox lstInventaireLoue;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblProduitEnStockEtTotal;
        private System.Windows.Forms.Label lblListeLocationTotal;
    }
}