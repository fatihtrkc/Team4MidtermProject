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
        }

        Team4ContextBL dbbl;
        User user;
        int counter = 3;

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                user = dbbl.UserBL.FindByEmail(txtEmail.Text);
                if (user != null && user.ActivePassiveSituation)
                {
                    txtEmail.Enabled = false;
                    button2.Enabled = false;
                    Location();

                    lblOzelSoru.Text = user.SpecificQuestion;
                    
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


        private void button1_Click(object sender, EventArgs e)
        {
            if (user.QuestionAnswer == txtCevap.Text && user.Name == txtName.Text && user.Surname == txtSurname.Text)
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
        private void Location()
        {
            lblMail.Location = new Point(41, 29);
            txtEmail.Location = new Point(124, 24);
            button2.Location = new Point(138, 53);
            lblOzelSoru.Location = new Point(61, 179);
            lblAnswer.Location = new Point(47, 215);
            txtCevap.Location = new Point(159, 216);
            button1.Location = new Point(138, 254);
            lblName.Location = new Point(47, 110);
            lblSurname.Location = new Point(47, 139);
            txtName.Location = new Point(124, 111);
            txtSurname.Location = new Point(124, 139);
        }
    }
}
