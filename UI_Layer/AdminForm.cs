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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminCategoriesForm form = new();
            form.ShowDialog();
            this.Show();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFoodsForm form = new();
            form.ShowDialog();
            this.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminUsersForm form = new();
            form.ShowDialog();
            this.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
