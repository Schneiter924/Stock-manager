namespace Stock_manager
{
    partial class frmReMenu
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
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdHors = new System.Windows.Forms.Button();
            this.cmdHistorique = new System.Windows.Forms.Button();
            this.cmdMot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(12, 99);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(137, 23);
            this.cmdQuitter.TabIndex = 8;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // cmdHors
            // 
            this.cmdHors.Location = new System.Drawing.Point(12, 70);
            this.cmdHors.Name = "cmdHors";
            this.cmdHors.Size = new System.Drawing.Size(137, 23);
            this.cmdHors.TabIndex = 7;
            this.cmdHors.Text = "hors-délai";
            this.cmdHors.UseVisualStyleBackColor = true;
            this.cmdHors.Click += new System.EventHandler(this.cmdHors_Click);
            // 
            // cmdHistorique
            // 
            this.cmdHistorique.Location = new System.Drawing.Point(12, 41);
            this.cmdHistorique.Name = "cmdHistorique";
            this.cmdHistorique.Size = new System.Drawing.Size(137, 23);
            this.cmdHistorique.TabIndex = 6;
            this.cmdHistorique.Text = "Historique";
            this.cmdHistorique.UseVisualStyleBackColor = true;
            this.cmdHistorique.Click += new System.EventHandler(this.cmdHistorique_Click);
            // 
            // cmdMot
            // 
            this.cmdMot.Location = new System.Drawing.Point(12, 12);
            this.cmdMot.Name = "cmdMot";
            this.cmdMot.Size = new System.Drawing.Size(137, 23);
            this.cmdMot.TabIndex = 5;
            this.cmdMot.Text = "mot-clé";
            this.cmdMot.UseVisualStyleBackColor = true;
            this.cmdMot.Click += new System.EventHandler(this.cmdMot_Click);
            // 
            // frmReMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 148);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdHors);
            this.Controls.Add(this.cmdHistorique);
            this.Controls.Add(this.cmdMot);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdHors;
        private System.Windows.Forms.Button cmdHistorique;
        private System.Windows.Forms.Button cmdMot;
    }
}