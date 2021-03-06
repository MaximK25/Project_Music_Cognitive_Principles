namespace Project_Music_Cognitive_Principles
{
    partial class Register_Form
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
            this.components = new System.ComponentModel.Container();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.tb_Privacy = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_RF = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.cb_Privacy = new System.Windows.Forms.CheckBox();
            this.tb_UserCaptcha_RF = new System.Windows.Forms.TextBox();
            this.btn_RefreshCaptcha_LF = new System.Windows.Forms.Button();
            this.tb_Captcha_RF = new System.Windows.Forms.TextBox();
            this.label1_RF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(251, 69);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(258, 22);
            this.txt_UserName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(251, 184);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(258, 22);
            this.txt_Password.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(251, 125);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(258, 22);
            this.txt_Email.TabIndex = 3;
            // 
            // tb_Privacy
            // 
            this.tb_Privacy.Enabled = false;
            this.tb_Privacy.Location = new System.Drawing.Point(251, 362);
            this.tb_Privacy.Multiline = true;
            this.tb_Privacy.Name = "tb_Privacy";
            this.tb_Privacy.Size = new System.Drawing.Size(258, 77);
            this.tb_Privacy.TabIndex = 4;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(169, 557);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(92, 33);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(392, 557);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 35);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(69, 65);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 25);
            this.lbl_UserName.TabIndex = 7;
            this.lbl_UserName.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "I agree the Privacy Policy";
            // 
            // label3_RF
            // 
            this.label3_RF.AutoSize = true;
            this.label3_RF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_RF.Location = new System.Drawing.Point(61, 362);
            this.label3_RF.Name = "label3_RF";
            this.label3_RF.Size = new System.Drawing.Size(147, 25);
            this.label3_RF.TabIndex = 9;
            this.label3_RF.Text = "Privacy Policy";
            this.label3_RF.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(69, 180);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 25);
            this.lbl_Password.TabIndex = 10;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(69, 121);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(65, 25);
            this.lbl_Email.TabIndex = 11;
            this.lbl_Email.Text = "Email";
            // 
            // cb_Privacy
            // 
            this.cb_Privacy.AutoSize = true;
            this.cb_Privacy.Location = new System.Drawing.Point(243, 464);
            this.cb_Privacy.Name = "cb_Privacy";
            this.cb_Privacy.Size = new System.Drawing.Size(18, 17);
            this.cb_Privacy.TabIndex = 12;
            this.cb_Privacy.UseVisualStyleBackColor = true;
            this.cb_Privacy.CheckedChanged += new System.EventHandler(this.cb_Privacy_CheckedChanged_1);
            // 
            // tb_UserCaptcha_RF
            // 
            this.tb_UserCaptcha_RF.Location = new System.Drawing.Point(251, 296);
            this.tb_UserCaptcha_RF.Name = "tb_UserCaptcha_RF";
            this.tb_UserCaptcha_RF.Size = new System.Drawing.Size(250, 22);
            this.tb_UserCaptcha_RF.TabIndex = 16;
            // 
            // btn_RefreshCaptcha_LF
            // 
            this.btn_RefreshCaptcha_LF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RefreshCaptcha_LF.Location = new System.Drawing.Point(543, 243);
            this.btn_RefreshCaptcha_LF.Name = "btn_RefreshCaptcha_LF";
            this.btn_RefreshCaptcha_LF.Size = new System.Drawing.Size(75, 23);
            this.btn_RefreshCaptcha_LF.TabIndex = 15;
            this.btn_RefreshCaptcha_LF.Text = "Refresh";
            this.btn_RefreshCaptcha_LF.UseVisualStyleBackColor = true;
            this.btn_RefreshCaptcha_LF.Click += new System.EventHandler(this.btn_RefreshCaptcha_LF_Click);
            // 
            // tb_Captcha_RF
            // 
            this.tb_Captcha_RF.Enabled = false;
            this.tb_Captcha_RF.Location = new System.Drawing.Point(251, 243);
            this.tb_Captcha_RF.Name = "tb_Captcha_RF";
            this.tb_Captcha_RF.Size = new System.Drawing.Size(258, 22);
            this.tb_Captcha_RF.TabIndex = 14;
            // 
            // label1_RF
            // 
            this.label1_RF.AutoSize = true;
            this.label1_RF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_RF.Location = new System.Drawing.Point(69, 239);
            this.label1_RF.Name = "label1_RF";
            this.label1_RF.Size = new System.Drawing.Size(93, 25);
            this.label1_RF.TabIndex = 13;
            this.label1_RF.Text = "Captcha";
            // 
            // Register_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 687);
            this.Controls.Add(this.tb_UserCaptcha_RF);
            this.Controls.Add(this.btn_RefreshCaptcha_LF);
            this.Controls.Add(this.tb_Captcha_RF);
            this.Controls.Add(this.label1_RF);
            this.Controls.Add(this.cb_Privacy);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.label3_RF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Privacy);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Name = "Register_Form";
            this.Text = "Register_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox tb_Privacy;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_RF;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.CheckBox cb_Privacy;
        private System.Windows.Forms.TextBox tb_UserCaptcha_RF;
        private System.Windows.Forms.Button btn_RefreshCaptcha_LF;
        private System.Windows.Forms.TextBox tb_Captcha_RF;
        private System.Windows.Forms.Label label1_RF;
    }
}