using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
using Guna.UI2.WinForms;
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
    public partial class UserDetails : Form
    {
        public UserDetails(int id)
        {
            InitializeComponent();
            userId = id;
            dbbl = new();
        }
        int userId;
        Team4ContextBL dbbl;
        private void UserDetails_Load(object sender, EventArgs e)
        {
            FillDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = dbbl.UserBL.Find(userId);

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                user.Name = txtName.PlaceholderText;
            }
            else
            {
                user.Name = txtName.Text;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                user.Surname = txtSurname.PlaceholderText;
            }
            else
            {
                user.Surname = txtSurname.Text;
            }
            if (IsOverFifteen(dtBirth))
            {
                user.BirthDate = dtBirth.Value;

            }
            else
            {
                MessageBox.Show("15 yaşından küçüklerin bu uygulamayı kullanması uygun değildir!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bool isUpdated = dbbl.UserBL.Update(user);
            if (isUpdated)
            {
                MessageBox.Show("Bilgileriniz güncellendi");
                FillDetails();
            }
            else
            {
                MessageBox.Show("Bilgiler güncellenirken bir hata oluştu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FillDetails()
        {
            txtName.Clear();
            txtSurname.Clear();
            User user = dbbl.UserBL.Find(userId);
            txtName.PlaceholderText = user.Name;
            txtSurname.PlaceholderText = user.Surname;
            dtBirth.Value = user.BirthDate;
        }
    }
}
