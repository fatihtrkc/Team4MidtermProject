using BusinessLayer.ContextBL;
using BusinessLayer.EntitiesBL;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
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
    public partial class AdminChangeSituation : Form
    {
        public AdminChangeSituation()
        {
            InitializeComponent();
            userbl = new();
        }

        UserBL userbl;


        private void AdminChangeSituation_Load(object sender, EventArgs e)
        {
            FillList();
        }



        private void lviewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviewUsers.SelectedItems.Count > 0)
            {

                User user = (User)lviewUsers.SelectedItems[0].Tag;
                string name = user.Name.ToLower() + " " + user.Surname.ToLower();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                txtName.Text = textInfo.ToTitleCase(name);
                txtMail.Text = user.Email;
                dtCreat.Value = user.CreationDate;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lviewUsers.SelectedItems.Count > 0)
            {
                User user = (User)lviewUsers.SelectedItems[0].Tag;
                if (user.ActivePassiveSituation)
                {
                    user.ActivePassiveSituation = false;
                }
                else
                {
                    user.ActivePassiveSituation = true;
                }
                bool isChanged = userbl.Update(user);
                if (isChanged)
                {
                    MessageBox.Show("Kullanıcının durumu değiştirildi");
                }
                else
                {
                    MessageBox.Show("Hata oldu değişim gerçekleşmedi");
                }
                FillList();
            }

        }
        private void FillList()
        {
            lviewUsers.Items.Clear();
            List<User> users = userbl.GetAll();
            foreach (User user in users)
            {
                ListViewItem lv = new ListViewItem();
                string name = user.Name.ToLower() + " " + user.Surname.ToLower();
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                lv.Text = textInfo.ToTitleCase(name);
                lv.SubItems.Add(user.Email);
                if (user.ActivePassiveSituation)
                {
                    lv.SubItems.Add("Aktif");
                }
                else
                {
                    lv.SubItems.Add("Pasif");
                }
                lv.Tag = user;

                lviewUsers.Items.Add(lv);
            }
        }
    }
}
