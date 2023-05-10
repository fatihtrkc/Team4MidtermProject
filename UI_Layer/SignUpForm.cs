using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
using EntityLayer.Enums;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            dbbll = new();
        }
        Team4ContextBL dbbll;
        User user;
        private void button1_Click(object sender, EventArgs e)
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
                    LifeStyleType lifeId = (LifeStyleType)cboxLifeStyle.SelectedValue;


                    if (txtPassword.Text == txtAgain.Text)
                    {
                        user = new User();
                        user.Name = txtName.Text;
                        user.Surname = txtSurname.Text;
                        user.Email = txtMail.Text;
                        user.Gender = rdMale.Checked ? EntityLayer.Enums.Gender.Male : EntityLayer.Enums.Gender.Female;
                        user.LifeStyleId = lifeId;
                        user.Password = txtPassword.Text;
                        user.SpecificQuestion = txtSpe.Text;
                        user.QuestionAnswer = txtSpeAns.Text;
                        user.BirthDate = dtBirth.Value;
                        user.Height = (double)nudHeight.Value;
                        user.Weight = (double)nudWeight.Value;
                        bool isAdded = dbbll.UserBL.Add(user);


                        if (isAdded)
                        {
                            MessageBox.Show("Kullanıcı başarıyla oluşturuldu", "İŞLEM ONAYLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Bir hata oldu. Kullanıcı eklenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        private bool IsOverFifteen(DateTimePicker birthdatePicker)
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

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            List<LifeStyle> lifeStyles = dbbll.LifeStyleBL.GetAll();
            cboxLifeStyle.DisplayMember = "Description";
            cboxLifeStyle.ValueMember = "Type";
            cboxLifeStyle.DataSource = lifeStyles;
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

        
    }
}
