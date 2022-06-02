namespace Project_Music_Cognitive_Principles
{
    partial class Form1
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
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserCaptcha = new System.Windows.Forms.TextBox();
            this.txt_Captcha = new System.Windows.Forms.TextBox();
            this.btn_RefreshCaptcha = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Captcha = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(193, 61);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(243, 22);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(193, 135);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(243, 22);
            this.txt_Password.TabIndex = 1;
            // 
            // txt_UserCaptcha
            // 
            this.txt_UserCaptcha.Location = new System.Drawing.Point(193, 273);
            this.txt_UserCaptcha.Name = "txt_UserCaptcha";
            this.txt_UserCaptcha.Size = new System.Drawing.Size(243, 22);
            this.txt_UserCaptcha.TabIndex = 2;
            // 
            // txt_Captcha
            // 
            this.txt_Captcha.Enabled = false;
            this.txt_Captcha.Location = new System.Drawing.Point(193, 199);
            this.txt_Captcha.Name = "txt_Captcha";
            this.txt_Captcha.Size = new System.Drawing.Size(243, 22);
            this.txt_Captcha.TabIndex = 3;
            // 
            // btn_RefreshCaptcha
            // 
            this.btn_RefreshCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshCaptcha.Location = new System.Drawing.Point(461, 254);
            this.btn_RefreshCaptcha.Name = "btn_RefreshCaptcha";
            this.btn_RefreshCaptcha.Size = new System.Drawing.Size(122, 41);
            this.btn_RefreshCaptcha.TabIndex = 4;
            this.btn_RefreshCaptcha.Text = "Refresh";
            this.btn_RefreshCaptcha.UseVisualStyleBackColor = true;
            this.btn_RefreshCaptcha.Click += new System.EventHandler(this.btn_RefreshCaptcha_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(61, 355);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(122, 33);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(262, 358);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(122, 30);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(461, 352);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(122, 39);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(39, 61);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(141, 31);
            this.lbl_UserName.TabIndex = 8;
            this.lbl_UserName.Text = "UserName";
            // 
            // lbl_Captcha
            // 
            this.lbl_Captcha.AutoSize = true;
            this.lbl_Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Captcha.Location = new System.Drawing.Point(39, 199);
            this.lbl_Captcha.Name = "lbl_Captcha";
            this.lbl_Captcha.Size = new System.Drawing.Size(93, 25);
            this.lbl_Captcha.TabIndex = 9;
            this.lbl_Captcha.Text = "Captcha";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(39, 135);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(133, 31);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 416);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Captcha);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_RefreshCaptcha);
            this.Controls.Add(this.txt_Captcha);
            this.Controls.Add(this.txt_UserCaptcha);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Form1";
            this.Text = "Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserCaptcha;
        private System.Windows.Forms.TextBox txt_Captcha;
        private System.Windows.Forms.Button btn_RefreshCaptcha;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Captcha;
        private System.Windows.Forms.Label lbl_Password;
    }
}

