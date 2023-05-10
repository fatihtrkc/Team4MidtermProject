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

        private void button1_Click(object sender, EventArgs e)
        {
            User user = dbbll.UserBL.Find(userId);
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtAgain.Text))
            {
                if (txtPassword.Text == txtAgain.Text)
                {
                    user.Password = txtAgain.Text;
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
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Alanları boş bırakmamalısınız", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
