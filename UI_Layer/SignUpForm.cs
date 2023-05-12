using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
using EntityLayer.Enums;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Layer
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            dbbll = new();
        }
        public SignUpForm(string Name, string Surname, string Mail, string Password, string Speque, string Answer, DateTime DateTime)
        {
            InitializeComponent();
            txtName.Text = Name;
            txtSurname.Text = Surname;
            txtMail.Text = Mail;
            txtPassword.Text = Password;
            txtAgain.Text = Password;
            txtSpe.Text = Speque;
            txtSpeAns.Text = Answer;
            dtBirth.Value = DateTime;
        }

        Team4ContextBL dbbll;
        User user;



        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private bool alreadyMail(string mail)
        {
            mail = txtMail.Text;
            user = dbbll.UserBL.FindByEmail(mail);
            if (user != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {

                        MessageBox.Show("Tüm veriler girilmelidir");
                        return;
                    }
                }
            }

            if (!alreadyMail(txtMail.Text))
            {
                MessageBox.Show("Bu mail adresi zaten kullanılıyor!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsOverFifteen(dtBirth))
                {

                    if (txtPassword.Text == txtAgain.Text)
                    {

                        string name = txtName.Text;
                        string surname = txtSurname.Text;
                        string email = txtMail.Text;
                        string password = txtPassword.Text;
                        string speque = txtSpe.Text;
                        string answer = txtSpeAns.Text;
                        DateTime dateTime = dtBirth.Value;

                        this.Hide();
                        SingUpSecond singUpSecond = new SingUpSecond(name, surname, email, password, speque, answer, dateTime);
                        singUpSecond.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Şifreler uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("15 yaşından küçükler bu uygulamayı kullanamaz");
                }

            }
        }
        private bool IsOverFifteen(Guna2DateTimePicker birthdatePicker)
        {
            DateTime birthdate = birthdatePicker.Value;
            DateTime today = DateTime.Now.AddYears(-15); ;
            if (birthdate < today)
            {
                return true;
            }
            else
                return false;
        }
    }
}
