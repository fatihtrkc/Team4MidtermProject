using BusinessLayer.ContextBL;
using DataAccessLayer.Context;
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
    public partial class FoodStatisticsForm : Form
    {
        public FoodStatisticsForm(int id)
        {
            InitializeComponent();
            userId = id;
            dbbl = new();
        }
        int userId;
        Team4ContextBL dbbl;
        private void FoodStatisticsForm_Load(object sender, EventArgs e)
        {
            FillList();
            FillListTopFood();
        }

        private void FillList()
        {
            lviewFoods.Items.Clear();
            List<Food> foods = dbbl.FoodBL.GetAll();

            foreach (Food item in foods)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Breakfast).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Lunch).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Dinner).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Snack).ToString());

                lviewFoods.Items.Add(lvi);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lviewFoods.Items.Clear();
            List<Food> list = dbbl.FoodBL.GetByText(txtSearch.Text);
            foreach (Food item in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Name;
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Breakfast).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Lunch).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Dinner).ToString());
                lvi.SubItems.Add(dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Snack).ToString());

                lviewFoods.Items.Add(lvi);
            }
        }

        private void FillListTopFood()
        {
            lviewTop.Items.Clear();
            List<Food> list = dbbl.FoodBL.GetByText(txtSearch.Text);
            foreach (Food item in list)
            {
                int kahvalti = dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Breakfast);
                int oglen = dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Lunch);
                int aksam = dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Dinner);
                int ara = dbbl.AddedFoodBL.GetCountFood(userId, item.Id, MealType.Snack);
                int toplam = kahvalti + oglen + aksam + ara;
                if (toplam > 0)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.Name;
                    lvi.SubItems.Add(toplam.ToString());

                    lviewTop.Items.Add(lvi);
                }

            }


        }
    }
}
