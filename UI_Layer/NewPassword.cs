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
    public partial class NewPassword : Form
    {
        public NewPassword(int id)
        {
            InitializeComponent();
            userId = id;
            dbbl = new();
        }
        int userId;
        Team4ContextBL dbbl;
        private void NewPassword_Load(object sender, EventArgs e)
        {

        }
        private void btnSifre_Click(object sender, EventArgs e)
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
            User user = dbbl.UserBL.Find(userId);
            if (txtOldPassword.Text != user.Password)
            {
                MessageBox.Show("Eski şifrenizi yanlış girdiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNewPassword.Text != txtNewAgain.Text)
                {
                    MessageBox.Show("Yeni girdiğiniz şifre birbiriyle uyuşmuyor!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    user.Password = txtNewAgain.Text;

                    bool isUpdated = dbbl.UserBL.Update(user);
                    if (isUpdated)
                    {
                        MessageBox.Show("Şifreniz güncelledi");
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncellenemedi");
                    }
                }
            }
        }
    }
}
