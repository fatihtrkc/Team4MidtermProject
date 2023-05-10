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
        int count = 0;
        double totalCalory;
        private void UserPage_Load(object sender, EventArgs e)
        {
            User user = dbbl.UserBL.Find(userId);
            lblAdSoyad.Text = "Hoşgeldin " + user.Name + " " + user.Surname;
            lblBoy.Text = user.Height.ToString();
            lblKilo.Text = user.Weight.ToString();

            FillList(DateTime.Today);
            lblTotalCalory.Text = totalCalory.ToString("N2");
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
        private void chboxKahvalti_CheckedChanged(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxOgle_CheckedChanged(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxAksam_CheckedChanged(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxAraOgun_CheckedChanged(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void FillListMeal(DateTime time, MealType type)
        {
            List<AddedFood> addeds = dbbl.AddedFoodBL.GetAllByUserIdAndDayAndMeal(userId, time, type);
            foreach (AddedFood item in addeds)
            {
                ListViewItem lv = new ListViewItem();
                Food food = dbbl.FoodBL.Find(item.FoodId);
                Meal meal = dbbl.MealBL.FindByMeal(item.MealId);
                lv.Text = food.Name;
                lv.SubItems.Add(item.Quantity.ToString());
                lv.SubItems.Add(item.TotalCalory.ToString());

                if (meal.Name == MealType.Breakfast)
                {
                    lv.SubItems.Add("Kahvaltı");
                }
                else if (meal.Name == MealType.Lunch)
                {
                    lv.SubItems.Add("Öğle Yemeği");
                }
                else if (meal.Name == MealType.Snack)
                {
                    lv.SubItems.Add("Ara Öğün");
                }
                else if (meal.Name == MealType.Dinner)
                {
                    lv.SubItems.Add("Akşam Yemeği");
                }


                lviewGunluk.Items.Add(lv);

            }

        }

        private void FillList(DateTime time)
        {
            totalCalory = 0;
            lviewGunluk.Items.Clear();
            MealType type;
            if (chboxKahvalti.Checked)
            {
                type = MealType.Breakfast;
                FillListMeal(time, type);
                totalCalory += dbbl.AddedFoodBL.GetSumColory(userId, time, type);
            }
            if (chboxAksam.Checked)
            {
                type = MealType.Dinner;
                FillListMeal(time, type);
                totalCalory += dbbl.AddedFoodBL.GetSumColory(userId, time, type);
            }
            if (chboxAraOgun.Checked)
            {
                type = MealType.Snack;
                FillListMeal(time, type);
                totalCalory += dbbl.AddedFoodBL.GetSumColory(userId, time, type);
            }
            if (chboxOgle.Checked)
            {
                type = MealType.Lunch;
                FillListMeal(time, type);
                totalCalory += dbbl.AddedFoodBL.GetSumColory(userId, time, type);
            }
            lblTotalCalory.Text = totalCalory.ToString("N2");
        }

    }
}
