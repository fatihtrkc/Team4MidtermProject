using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
using EntityLayer.Entities;
using EntityLayer.Enums;
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
        User user;
        private void UserPage_Load(object sender, EventArgs e)
        {
            user = dbbl.UserBL.Find(userId);
            string name = user.Name.ToLower() + " " + user.Surname.ToLower();
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            lblAdSoyad.Text = "Hoşgeldin " + textInfo.ToTitleCase(name);
            lblBoy.Text = user.Height.ToString();
            lblKilo.Text = user.Weight.ToString();
            TargetCalory(user);
            FillList(DateTime.Today);
            lblTotal.Text = "Toplam Alınan Kalori Miktarı" + " " + totalCalory.ToString("N2");
            FillTargetCalory(user);


        }
        private void btnToday_Click_1(object sender, EventArgs e)
        {
            count = 0;
            FillList(DateTime.Today);
        }

        private void btnUpDay_Click_1(object sender, EventArgs e)
        {
            count++;
            FillList(DateTime.Today.AddDays(count));
        }

        private void btnDownDay_Click_1(object sender, EventArgs e)
        {
            count--;
            FillList(DateTime.Today.AddDays(count));
        }
        private void chboxAraOgun_CheckedChanged_1(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxAksam_CheckedChanged_1(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxOgle_CheckedChanged_1(object sender, EventArgs e)
        {
            FillList(DateTime.Today.AddDays(count));
        }

        private void chboxKahvalti_CheckedChanged(object sender, EventArgs e)
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

        }

        public void FillTargetCalory(User user)
        {
            double target = TargetCalory(user);
            lblTarget.Text = "Günlük İhtiyacım Olan Kalori:" + " " + target.ToString("N2");
        }

        /// <summary>
        /// Kullanıcının aktivite biçimi ve uygulamayı kullanım amacına göre günlük alması gereken kalori hesabının yapıldığı metot.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private double TargetCalory(User user)
        {
            double bmr;
            double activity;
            double goal;
            if (user.Gender == Gender.Male)
            {
                bmr = 66 + (13.75 * user.Weight) + (5 * user.Height) - (6.75 * (DateTime.Now.Year - user.BirthDate.Year));
                activity = ActivityFactor(user, bmr);
                goal = GoalFactor(user, activity);
            }
            else
            {
                bmr = 655 + (9.56 * user.Weight) + (1.85 * user.Height) - (4.68 * (DateTime.Now.Year - user.BirthDate.Year));
                activity = ActivityFactor(user, bmr);
                goal = GoalFactor(user, activity);
            }
            return goal;
        }
        /// <summary>
        /// Aktivite yoğunluğuna göre günlük alınması gereken kalori miktarı.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="bmr"></param>
        /// <returns></returns>
        private double ActivityFactor(User user, double bmr)
        {

            if (user.LifeStyleId == LifeStyleType.Never)
            {
                bmr = bmr * 1.2;

            }
            else if (user.LifeStyleId == LifeStyleType.Low)
            {
                bmr = bmr * 1.375;
            }
            else if (user.LifeStyleId == LifeStyleType.Middle)
            {
                bmr = bmr * 1.55;
            }
            else if (user.LifeStyleId == LifeStyleType.High)
            {
                bmr = bmr * 1.725;
            }
            else if (user.LifeStyleId == LifeStyleType.More)
            {
                bmr = bmr * 1.9;
            }
            return bmr;
        }
        /// <summary>
        /// Uygulamayı kullanım amacına göre kalori hesabı yapılması.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="bmr"></param>
        /// <returns></returns>
        private double GoalFactor(User user, double bmr)
        {
            double goalCalory = 0;
            if (user.GoalTypeId == GoalType.Zayıflamak)
            {
                goalCalory = bmr - 500;
            }
            else if (user.GoalTypeId == GoalType.KiloAlmak)
            {
                goalCalory = bmr + 500;
            }
            else if (user.GoalTypeId == GoalType.HızlıKiloAlmak)
            {
                goalCalory = bmr + 2000;
            }
            else if (user.GoalTypeId == GoalType.KiloyuKorumak)
            {
                goalCalory = bmr;
            }
            return goalCalory;
        }

    }
}
