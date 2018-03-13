namespace Stock_manager
{
    partial class frmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdReset = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.cmdConnexion = new System.Windows.Forms.Button();
            this.cmdMdPPerdu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 38);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(29, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mot de passe";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(174, 35);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(182, 20);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(174, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(155, 123);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(75, 23);
            this.cmdReset.TabIndex = 4;
            this.cmdReset.Text = "reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(236, 123);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 5;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdConnexion
            // 
            this.cmdConnexion.Location = new System.Drawing.Point(317, 123);
            this.cmdConnexion.Name = "cmdConnexion";
            this.cmdConnexion.Size = new System.Drawing.Size(75, 23);
            this.cmdConnexion.TabIndex = 6;
            this.cmdConnexion.Text = "Connexion";
            this.cmdConnexion.UseVisualStyleBackColor = true;
            this.cmdConnexion.Click += new System.EventHandler(this.cmdConnexion_Click);
            // 
            // cmdMdPPerdu
            // 
            this.cmdMdPPerdu.Location = new System.Drawing.Point(0, 0);
            this.cmdMdPPerdu.Name = "cmdMdPPerdu";
            this.cmdMdPPerdu.Size = new System.Drawing.Size(75, 23);
            this.cmdMdPPerdu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Option de connextion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdConnexion);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion à l\'application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdReset;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Button cmdConnexion;
        private System.Windows.Forms.Button cmdMdPPerdu;
        private System.Windows.Forms.Button button1;
    }
}