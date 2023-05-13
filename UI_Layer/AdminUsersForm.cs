using BusinessLayer.EntitiesBL;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UI_Layer.Utilities;

namespace UI_Layer
{
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
            userbl = new();
        }
        UserBL userbl;
        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            dtgridPassiveUsers.DataSource = userbl.GetAllByUserSituation().Select(user => new { user.Email, user.ActivePassiveSituation }).OrderBy(user => user.Email).ToList();
            Helper.WriteSelectClear(this.Controls);
        }

        User user;
        string email;
        private void dtgridPassiveUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                email = dtgridPassiveUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                user = userbl.FindByEmail(email);
                if (user is not null)
                {
                    txtUsername.Text = user.Email;
                    btnUpdate.Enabled = true;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (user == userbl.FindByEmail(user.Email) && dtgridPassiveUsers.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show($"   {user.Email} üyesinin pasif olan durumunu aktif olarak değiştirme işlemini onaylıyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    user.ActivePassiveSituation = true;

                    bool IsUpdated = userbl.Update(user);
                    if (IsUpdated)
                    {
                        MessageBox.Show($"   {user.Email} üyesinin durumunu aktif olarak güncelleme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgridPassiveUsers.DataSource = userbl.GetAllByUserSituation().Select(user => new { user.Email, user.ActivePassiveSituation }).ToList();
                        Helper.WriteSelectClear(this.Controls);
                        txtUsername.Clear();
                        btnUpdate.Enabled = false;
                    }
                    else MessageBox.Show("Güncelleme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AdminUsersForm_Click(object sender, EventArgs e)
        {
            Helper.WriteSelectClear(this.Controls);
            txtUsername.Clear();
            btnUpdate.Enabled = false;
            user = null;
            email = null;
        }
        private void pctrbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pctrbxExit_MouseHover(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = Color.LightCoral;
        }
        private void pctrbxExit_MouseLeave(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = default;
        }
    }
}
