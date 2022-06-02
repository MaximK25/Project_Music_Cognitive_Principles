using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Music_Cognitive_Principles
{
    public partial class Form1 : Form
    {
        Login_Class Obj_data = new Login_Class();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var RegForm_Obj = new Register_Form();
            RegForm_Obj.Closed += (s, args) => this.Close();
            RegForm_Obj.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool val_Captcha = Obj_data.ValidateCaptcha(txt_Captcha.Text);
            if (val_Captcha)
            {
                string message = Obj_data.Login(txt_UserName.Text, txt_Password.Text);
                if (message == "User Login Successfully")

                {
                    MessageBox.Show(message);
                    this.Hide();
                    var DashboardForm_Obj = new DashboardForm();
                    DashboardForm_Obj.Closed += (s, args) => this.Close();
                    DashboardForm_Obj.Show();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Captcha");
            }
        }

        private void btn_RefreshCaptcha_Click(object sender, EventArgs e)
        {
            txt_Captcha.Text = Obj_data.GenerateCaptcha();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


    }
}
