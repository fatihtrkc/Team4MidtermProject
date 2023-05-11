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
    public partial class HomePage : Form
    {
        public HomePage(int id)
        {
            InitializeComponent();
            userId = id;
        }
        int userId;
        private void HomePage_Load(object sender, EventArgs e)
        {
            YeniFormEkle(new UserPage(userId));
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

        private void kahvaltıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new UserAddMeal(userId, EntityLayer.Enums.MealType.Breakfast));
        }

        private void öğlenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new UserAddMeal(userId, EntityLayer.Enums.MealType.Lunch));
        }

        private void akşamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new UserAddMeal(userId, EntityLayer.Enums.MealType.Dinner));
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new UserAddMeal(userId, EntityLayer.Enums.MealType.Snack));
        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new UserPage(userId));

        }

        private void günlükToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new ReportForm(userId));
        }

        private void haftalıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormEkle(new FoodStatisticsForm(userId));
        }
    }
}
