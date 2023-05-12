using BusinessLayer.EntitiesBL;
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
            dtgridPassiveUsers.DataSource = userbl.GetAllByUserSituation().Select(user => new { user.Name, user.Surname, user.ActivePassiveSituation }).ToList();
        }

        private void dtgridPassiveUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        private void AdminUsersForm_Click(object sender, EventArgs e)
        {
            Helper.WriteSelectClear(this.Controls);
        }
        private void pctrbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pctrbxExit_MouseHover(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = Color.LightCoral;
        }
        private void pctrbxExit_ClientSizeChanged(object sender, EventArgs e)
        {

            pctrbxExit.BackColor = default;
        }
    }
}
