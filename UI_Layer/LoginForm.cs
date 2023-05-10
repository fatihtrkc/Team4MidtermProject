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
            db = new Team4Context();
        }
        Team4Context db;
        User user;
        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtMail.Text) || !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                user = new User();
                if (user.Email == txtMail.Text) ;

            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }
    }
}
