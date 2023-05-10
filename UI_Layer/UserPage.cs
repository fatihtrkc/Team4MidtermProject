using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using EntityLayer.Enums;
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
    public partial class UserPage : Form
    {
        public UserPage(int id)
        {
            InitializeComponent();
            userId = id;
            dbbl = new();
        }
        int userId;
        Team4ContextBL dbbl;
        int up = 0;
        int count = 0;
        private void UserPage_Load(object sender, EventArgs e)
        {
            User user = dbbl.UserBL.Find(userId);
            lblAdSoyad.Text = "Hoşgeldin " + user.Name + " " + user.Surname;
            lblBoy.Text = user.Height.ToString();
            lblKilo.Text = user.Weight.ToString();

            FillList(DateTime.Today);
        }

        private void FillList(DateTime time)
        {
            lviewGunluk.Items.Clear();
            List<AddedFood> addeds = dbbl.AddedFoodBL.GetAllByUserIdAndDay(userId, time);
            foreach (AddedFood item in addeds)
            {
                ListViewItem lv = new ListViewItem();
                Food food = dbbl.FoodBL.Find(item.FoodId);
                Meal meal = dbbl.MealBL.FindByMeal(item.MealId);
                lv.Text = food.Name;
                lv.SubItems.Add(item.Quantity.ToString());
                lv.SubItems.Add(item.TotalCalory.ToString());
                lv.SubItems.Add(meal.Name.ToString());

                lviewGunluk.Items.Add(lv);
            }
        }

        private void btnDownDay_Click(object sender, EventArgs e)
        {
            count--;
            FillList(DateTime.Today.AddDays(count));
        }

        private void btnUpDay_Click(object sender, EventArgs e)
        {
            count++;
            FillList(DateTime.Today.AddDays(count));
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            count = 0;
            FillList(DateTime.Today);
        }
    }
}
