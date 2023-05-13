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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            YeniFormEkle(new AdminChangeSituation());
        }
        private void YeniFormEkle(Form form)
        {
            FormlariKapat();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            this.Width = form.Width + 50;
            this.Height = form.Height + 90;
            form.Show();
        }

        private void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new AdminAddFood());
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new AdminAddCategory());
        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new AdminChangeSituation());
        }
    }
}
