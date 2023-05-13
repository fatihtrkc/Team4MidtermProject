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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void FillList()
        {
            lviewMeal.Items.Clear();
            List<AddedFood> addeds = db.AddedFoodBL.GetAllByUserIdAndDayAndMeal(userId, DateTime.Today, mealType);
            foreach (AddedFood item in addeds)
            {
                ListViewItem lv = new ListViewItem();
                Food food = db.FoodBL.Find(item.FoodId);
                lv.Text = food.Name;
                lv.SubItems.Add(item.Quantity.ToString());
                lv.SubItems.Add(item.TotalCalory.ToString());
                lv.Tag = item;
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

        private void UserAddMeal_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lviewMeal.SelectedItems)
            {
                item.Selected = false;
            }
            btnAdd.Text = "Kaydet";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lviewMeal.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    AddedFood added = (AddedFood)lviewMeal.SelectedItems[0].Tag;
                    bool isDeleted = db.AddedFoodBL.Delete(added.Id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Yemek silindi");
                    }
                    else
                    {
                        MessageBox.Show("Yemek silinemedi");
                    }
                    FillList();

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi");
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (lviewMeal.SelectedItems.Count > 0)
            {
                AddedFood added = (AddedFood)lviewMeal.FocusedItem.Tag;
                added.UserId = userId;
                added.FoodId = (int)cboxYemekler.SelectedValue;
                added.Quantity = (int)nudPorsiyon.Value;

                Food food = db.FoodBL.Find(added.FoodId);
                double calory = food.CaloryPerUnit;
                added.TotalCalory = (double)(added.Quantity * calory);

                added.CreationDate = DateTime.Today;
                added.MealId = mealType;

                bool isUpdated = db.AddedFoodBL.Update(added);
                if (isUpdated)
                {
                    MessageBox.Show("Yemek bilgisi güncellendi");
                    FillList();
                    foreach (ListViewItem item in lviewMeal.SelectedItems)
                    {
                        item.Selected = false;
                    }
                }
                else
                {
                    MessageBox.Show("Yemek bilgisi güncellenemedi");
                }
                btnAdd.Text = "Kaydet";

            }
            else
            {
                AddedFood ad = new();
                ad.UserId = userId;
                ad.FoodId = (int)cboxYemekler.SelectedValue;
                ad.Quantity = (int)nudPorsiyon.Value;

                Food food = db.FoodBL.Find(ad.FoodId);
                double calory = food.CaloryPerUnit;
                ad.TotalCalory = (double)(ad.Quantity * calory);

                ad.CreationDate = DateTime.Today;
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
        }

        private void cboxCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            categoryId = (int)cboxCategories.SelectedValue;
            List<Food> foods = db.FoodBL.GetByCategory(categoryId);
            cboxYemekler.DisplayMember = "Name";
            cboxYemekler.ValueMember = "Id";
            cboxYemekler.DataSource = foods;
        }

        private void cboxYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int foodId = (int)cboxYemekler.SelectedValue;
            Food foods = db.FoodBL.Find(foodId);
            UnitType unit = foods.UnitId;
            lblUnitType.Text = unit.ToString();
            FillPictureBox(foodId);
        }

        private void lviewMeal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnAdd.Text = "Güncelle";
            if (lviewMeal.SelectedItems.Count > 0)
            {
                AddedFood added = (AddedFood)lviewMeal.SelectedItems[0].Tag;
                Food food = db.FoodBL.Find(added.FoodId);
                Category category = db.CategoryBL.Find(food.CategoryId);

                cboxCategories.SelectedValue = category.Id;
                cboxYemekler.SelectedValue = food.Id;
                nudPorsiyon.Value = (int)added.Quantity;


            }
        }
        private void FillPictureBox(int foodId)
        {
            Food food = db.FoodBL.Find(foodId);
            pboxYemekFoto.Image = Image.FromFile(food.Image);

        }
    }
}
