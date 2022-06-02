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
    public partial class Register_Form : Form     
    {
        Registration_Class Obj_Reg = new Registration_Class();
        public Register_Form()
        {
            InitializeComponent();
            tb_Privacy.Text = "This is a company Privacy Policy, Please read it Carefully";
            tb_Captcha_RF.Text = Obj_Reg.GenerateCaptcha();
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool val_Captcha = Obj_Reg.ValidateCaptcha(tb_Captcha_RF.Text);
            if (val_Captcha)
            {
                string message = Obj_Reg.Registration(txt_UserName.Text, txt_Email.Text, txt_Password.Text);
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
            //if (cb_Privacy.Checked)
            {
                string message = Obj_Reg.Registration(txt_UserName.Text, txt_Email.Text, txt_Password.Text);
                MessageBox.Show(message);
                txt_UserName.Text = "";
                txt_Email.Text = "";
                txt_Password.Text = "";
            }
            // else
            //{
            //    MessageBox.Show("Please accept the Privacy Policy");
            //}
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm_Obj = new Form1();
            LoginForm_Obj.Closed += (s, args) => this.Close();
            LoginForm_Obj.Show();
        }

        private void cb_Privacy_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_Privacy.Checked)
            {
                btn_Submit.Enabled = true;
            }
            else if (cb_Privacy.Checked==false)
            {
                btn_Submit.Enabled=false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }      

        private void btn_RefreshCaptcha_LF_Click(object sender, EventArgs e)
        {
            tb_Captcha_RF.Text = Obj_Reg.GenerateCaptcha();
        }

        //private void btn_RefreshCaptcha_LF_Click(object sender, EventArgs e)
        //{
        //    tb_Captcha_RF.Text = Obj_data.GenerateCaptcha();
        //}

        //private void cb_Privacy_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (cb_Privacy.Checked)
        //    {
        //        btn_Submit.Enabled = true;
        //    }
        //    else if (cb_Privacy.Checked == false)
        //    {
        //        MessageBox.Show("Please accept the Privacy Policy");
        //        btn_Submit.Enabled = false;
        //    }
        //}
        //private void btn_RefreshCaptcha_Click(object sender, EventArgs e)
        //{
        //    tb_Captcha_RF.Text = Obj_Reg.GenerateCaptcha();
        //}

    }
}
