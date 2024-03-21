namespace magicsquaregenerator
{
    partial class auth
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
            this.authLog = new System.Windows.Forms.TextBox();
            this.authPswrd = new System.Windows.Forms.TextBox();
            this.makeAuth = new System.Windows.Forms.Button();
            this.goReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authLog
            // 
            this.authLog.Location = new System.Drawing.Point(12, 12);
            this.authLog.Name = "authLog";
            this.authLog.Size = new System.Drawing.Size(240, 20);
            this.authLog.TabIndex = 0;
            this.authLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // authPswrd
            // 
            this.authPswrd.Location = new System.Drawing.Point(12, 60);
            this.authPswrd.Name = "authPswrd";
            this.authPswrd.PasswordChar = '*';
            this.authPswrd.Size = new System.Drawing.Size(240, 20);
            this.authPswrd.TabIndex = 1;
            // 
            // makeAuth
            // 
            this.makeAuth.Location = new System.Drawing.Point(12, 106);
            this.makeAuth.Name = "makeAuth";
            this.makeAuth.Size = new System.Drawing.Size(105, 23);
            this.makeAuth.TabIndex = 2;
            this.makeAuth.Text = "Войти";
            this.makeAuth.UseVisualStyleBackColor = true;
            this.makeAuth.Click += new System.EventHandler(this.makeAuth_Click);
            // 
            // goReg
            // 
            this.goReg.Location = new System.Drawing.Point(123, 106);
            this.goReg.Name = "goReg";
            this.goReg.Size = new System.Drawing.Size(129, 23);
            this.goReg.TabIndex = 3;
            this.goReg.Text = "Зарегистрироваться";
            this.goReg.UseVisualStyleBackColor = true;
            this.goReg.Click += new System.EventHandler(this.goReg_Click);
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 141);
            this.Controls.Add(this.goReg);
            this.Controls.Add(this.makeAuth);
            this.Controls.Add(this.authPswrd);
            this.Controls.Add(this.authLog);
            this.Name = "auth";
            this.Text = "auth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.auth_FormClosed);
            this.Load += new System.EventHandler(this.auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authLog;
        private System.Windows.Forms.TextBox authPswrd;
        private System.Windows.Forms.Button makeAuth;
        private System.Windows.Forms.Button goReg;
    }
}