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
    public partial class UserAddMeal : Form
    {
        public UserAddMeal(int id, MealType meal)
        {
            InitializeComponent();
            userId = id;
            mealType = meal;
            db = new();
        }
        int userId;
        MealType mealType;
        Team4ContextBL db;
        User user;
        DateTime DateTime;
        int categoryId;
        private void UserAddMeal_Load(object sender, EventArgs e)
        {
            FillComboBox();

            btnAdd.Text = "Kaydet";
            if (mealType == MealType.Breakfast)
            {
                lblMeal.Text = "Kahvaltı";
                FillList();

            }
            else if (mealType == MealType.Snack)
            {
                lblMeal.Text = "Ara Öğün";
                FillList();
            }
            else if (mealType == MealType.Dinner)
            {
                lblMeal.Text = "Akşam Yemekleri";
                FillList();
            }
            else
            {
                lblMeal.Text = "Öğlen Yemekleri";
                FillList();
            }
        }

        private void lviewKahvalti_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Güncelle";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddedFood ad = new();
            ad.UserId = userId;
            ad.FoodId = (int)cboxYemekler.SelectedValue;
            ad.Quantity = (int)nudPorsiyon.Value;

            Food food = db.FoodBL.Find(ad.FoodId);
            double calory = food.CaloryPerUnit;
            ad.TotalCalory = (double)(ad.Quantity * calory);

            ad.CreationDate = DateTime.Today;
            ad.TargetCaloryPerDay = 100;
            ad.MealId = mealType;


            bool isAdded = db.AddedFoodBL.Add(ad);
            if (isAdded)
            {
                MessageBox.Show("Yemek başarıyla eklendi");
                FillList();
            }
            else
            {
                MessageBox.Show("Yemek eklenemedi");
            }

        }

        private void cboxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryId = (int)cboxCategories.SelectedValue;
            List<Food> foods = db.FoodBL.GetByCategory(categoryId);
            cboxYemekler.DisplayMember = "Name";
            cboxYemekler.ValueMember = "Id";
            cboxYemekler.DataSource = foods;
        }

        private void FillList()
        {
            lviewMeal.Items.Clear();
            List<AddedFood> addeds = db.AddedFoodBL.GetMealByUserId(userId, mealType, DateTime.Today);
            foreach (AddedFood item in addeds)
            {
                ListViewItem lv = new ListViewItem();
                Food food = db.FoodBL.Find(item.FoodId);
                lv.Text = food.Name;
                lv.SubItems.Add(item.Quantity.ToString());
                lv.SubItems.Add(item.TotalCalory.ToString());
                lviewMeal.Items.Add(lv);
            }
        }

        private void FillComboBox()
        {
            List<Category> categories = db.CategoryBL.GetAll();
            cboxCategories.DisplayMember = "Name";
            cboxCategories.ValueMember = "Id";
            cboxCategories.DataSource = categories;

            categoryId = (int)cboxCategories.SelectedValue;
            List<Food> foods = db.FoodBL.GetByCategory(categoryId);
            cboxYemekler.DisplayMember = "Name";
            cboxYemekler.ValueMember = "Id";
            cboxYemekler.DataSource = foods;
        }
    }
}
