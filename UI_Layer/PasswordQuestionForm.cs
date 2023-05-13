using BusinessLayer.ContextBL;
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
    public partial class PasswordQuestionForm : Form
    {
        public PasswordQuestionForm()
        {
            InitializeComponent();
        }

        private void PasswordQuestionForm_Load(object sender, EventArgs e)
        {
            dbbl = new();
            ChangeButton(false);

        }

        Team4ContextBL dbbl;
        User user;
        int counter = 3;

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEMail.ToString()))
            {
                user = dbbl.UserBL.FindByEmail(txtEMail.Text);
                if (user != null && user.ActivePassiveSituation)
                {
                    txtEMail.Enabled = false;
                    ChangeButton(true);


                    lblSoru.Text = user.SpecificQuestion;

                }
                else if (user != null && user.ActivePassiveSituation == false)
                {
                    MessageBox.Show("Üyelik askıda admin ile iletişime geçin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            else
            {
                MessageBox.Show("Alanı doldurun", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            if (user.QuestionAnswer == txtCevap.Text.ToUpper() && user.Name == txtName.Text.ToUpper() && user.Surname == txtSurname.Text.ToUpper())
            {
                ResetPasswordForm form = new ResetPasswordForm(user.Id);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                if (counter != 0)
                {
                    counter--;
                    MessageBox.Show("Cevap Hatalı " + counter + " deneme hakkınız kaldı");
                    txtCevap.Clear();
                }
                else
                {
                    user.ActivePassiveSituation = false;
                }
            }
        }

        private void ChangeButton(bool check)
        {
            if (check)
            {
                btnSifre.Visible = true;
                txtName.Enabled = true;
                txtSurname.Enabled = true;
                txtCevap.Enabled = true;
                lblSoru.Visible = true;
            }
            else
            {
                txtName.Enabled = false;
                txtSurname.Enabled = false;
                txtCevap.Enabled = false;
                lblSoru.Visible = false;
                btnSifre.Visible = false;
            }
        }
    }
}
