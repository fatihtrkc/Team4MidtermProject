using BusinessLayer.ContextBL;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            dbbll = new();
        }
        Team4ContextBL dbbll;

      

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtMail.Clear();
            txtPassword.Clear();
            txtMail.Text = "ahmetyilmaz@yilmaz.com";
            txtPassword.Text = "123";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordQuestionForm form = new();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form = new SignUpForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMail.Text) || !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                int userid = dbbll.UserBL.Login(txtMail.Text, txtPassword.Text);
                if (userid > 0)
                {
                    HomePage homePage = new HomePage(userid);
                    this.Hide();
                    homePage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Giriş başarısız oldu", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Alanları doldurun");
            }
        }
    }
}
