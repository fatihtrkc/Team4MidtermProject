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
using UI_Layer.Utilities;

namespace UI_Layer
{
    public partial class ResetPasswordForm : Form
    {
        int userId;
        public ResetPasswordForm(int id)
        {
            InitializeComponent();
            userId = id;
            dbbll = new();
        }
        Team4ContextBL dbbll;
        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = dbbll.UserBL.Find(userId);
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtAgainPassword.Text))
            {
                MessageBox.Show("Alanları boş bırakmamalısınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNewPassword.Text != txtAgainPassword.Text)
                {
                    MessageBox.Show("Şifreler uyuşmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!Helper.SifreKontrol(txtNewPassword.Text))
                    {
                        MessageBox.Show("Şifre en az iki küçük harf, en az iki büyük harf ve en az bir özel karakter içermeli ve en az sekiz karakter uzunluğunda olmalıdır");
                        return;
                    }

                    user.Password = Helper.sha256_hash(txtNewPassword.Text);
                    bool isUpdated = dbbll.UserBL.Update(user);
                    if (isUpdated)
                    {
                        MessageBox.Show("Yeni şifre oluşturuldu");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifre oluşturulamadı");
                    }

                }

            }
        }
    }
}
