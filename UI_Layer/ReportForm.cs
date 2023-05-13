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
    public partial class ReportForm : Form
    {
        public ReportForm(int id)
        {
            InitializeComponent();
            db = new();
            userId = id;
        }
        int userId;
        Team4ContextBL db;
        private void ReportForm_Load(object sender, EventArgs e)
        {
            FillCategoriesList();
            FillMealList();
        }
        private void FillCategoriesList()
        {
            if (rdbWeek.Checked)
            {
                lviewCategory.Items.Clear();
                List<Category> allCategories = db.CategoryBL.GetAll();

                foreach (Category item in allCategories)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = item.Name;
                    lv.SubItems.Add(db.AddedFoodBL.GetTotalCalory(userId, item.Id, DateTime.Today.AddDays(-7)).ToString("N2"));
                    lv.SubItems.Add(db.AddedFoodBL.GetAverageCalory(item.Id, DateTime.Today.AddDays(-7)).ToString("N2"));
                    lviewCategory.Items.Add(lv);
                }
            }
            else if (rdbMounth.Checked)
            {
                lviewCategory.Items.Clear();
                List<Category> allCategories = db.CategoryBL.GetAll();

                foreach (Category item in allCategories)
                {
                    ListViewItem lv = new ListViewItem();
                    lv.Text = item.Name;
                    lv.SubItems.Add(db.AddedFoodBL.GetTotalCalory(userId, item.Id, DateTime.Today.AddDays(-30)).ToString("N2"));
                    lv.SubItems.Add(db.AddedFoodBL.GetAverageCalory(item.Id, DateTime.Today.AddDays(-30)).ToString("N2"));
                    lviewCategory.Items.Add(lv);
                }
            }
        }

        private void FillMealList()
        {
            if (rdbWeek.Checked)
            {
                lviewMeal.Items.Clear();
                List<Meal> allMeal = db.MealBL.GetAll();

                foreach (Meal item in allMeal)
                {
                    ListViewItem lv = new ListViewItem();
                    if (item.Name == MealType.Breakfast)
                    {
                        lv.Text = "Kahvaltı";
                    }
                    else if (item.Name == MealType.Lunch)
                    {
                        lv.Text = "Öğle Yemeği";
                    }
                    else if (item.Name == MealType.Dinner)
                    {
                        lv.Text = "Akşam Yemeği";
                    }
                    else if (item.Name == MealType.Snack)
                    {
                        lv.Text = "Ara Öğün";
                    }
                    lv.SubItems.Add(db.AddedFoodBL.GetSumCaloryPerMeal(userId, item.Name, DateTime.Today.AddDays(-7)).ToString("N2"));
                    lv.SubItems.Add(db.AddedFoodBL.GetAverageCaloryPerMeal(item.Name, DateTime.Today.AddDays(-7)).ToString("N2"));
                    lviewMeal.Items.Add(lv);
                }
            }
            else if (rdbMounth.Checked)
            {
                lviewMeal.Items.Clear();
                List<Meal> allMeal = db.MealBL.GetAll();

                foreach (Meal item in allMeal)
                {
                    ListViewItem lv = new ListViewItem();
                    if (item.Name == MealType.Breakfast)
                    {
                        lv.Text = "Kahvaltı";
                    }
                    else if (item.Name == MealType.Lunch)
                    {
                        lv.Text = "Öğle Yemeği";
                    }
                    else if (item.Name == MealType.Dinner)
                    {
                        lv.Text = "Akşam Yemeği";
                    }
                    else if (item.Name == MealType.Snack)
                    {
                        lv.Text = "Ara Öğün";
                    }
                    lv.SubItems.Add(db.AddedFoodBL.GetSumCaloryPerMeal(userId, item.Name, DateTime.Today.AddDays(-30)).ToString("N2"));
                    lv.SubItems.Add(db.AddedFoodBL.GetAverageCaloryPerMeal(item.Name, DateTime.Today.AddDays(-30)).ToString("N2"));
                    lviewMeal.Items.Add(lv);
                }
            }
        }
        private void rdbWeek_CheckedChanged(object sender, EventArgs e)
        {
            FillCategoriesList();
            FillMealList();
        }

        private void rdbMounth_CheckedChanged(object sender, EventArgs e)
        {
            FillCategoriesList();
            FillMealList();
        }
    }
}
