using BusinessLayer.ContextBL;
using BusinessLayer.EntitiesBL;
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
    public partial class AdminAddFood : Form
    {
        public AdminAddFood()
        {
            InitializeComponent();
            dbbl = new();
            openFileDialog = new OpenFileDialog();
        }

        Team4ContextBL dbbl;
        OpenFileDialog openFileDialog;
        private void AdminAddFood_Load(object sender, EventArgs e)
        {
            FillCbox();
            FillListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Yemek Adı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnAdd.Text == "Güncelle")
                {
                    Food food = (Food)lviewFood.SelectedItems[0].Tag;
                    food.Name = txtFoodName.Text;
                    food.CategoryId = (int)cboxCategories.SelectedValue;
                    food.CaloryPerUnit = (double)nudCalory.Value;
                    food.UnitId = (UnitType)cboxUnit.SelectedValue;
                    food.Image = openFileDialog.FileName;
                    bool isupdated = dbbl.FoodBL.Update(food);
                    if (isupdated)
                    {
                        MessageBox.Show("Yemek güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillListView();
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Yemek güncellenemedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Food food = new Food();
                    food.Name = txtFoodName.Text;
                    food.CategoryId = (int)cboxCategories.SelectedValue;
                    food.CaloryPerUnit = (double)nudCalory.Value;
                    food.UnitId = (UnitType)cboxUnit.SelectedValue;
                    food.Image = openFileDialog.FileName;

                    bool isAdded = dbbl.FoodBL.Add(food);
                    if (!isAdded)
                    {
                        MessageBox.Show("Yemek ekleme sırasında bir hata oluştu ve yemek eklenemedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        MessageBox.Show("Yemek başarıyla eklendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        FillListView();
                    }
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (lviewFood.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    Food food = (Food)lviewFood.SelectedItems[0].Tag;
                    bool isDeleted = dbbl.FoodBL.Delete(food.Id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Yemek silindi!");
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Yemek silinemedi!");
                    }
                    FillListView();
                }
            }
        }

        private void lviewFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Güncelle";
            if (lviewFood.SelectedItems.Count > 0)
            {

                Food food = (Food)lviewFood.SelectedItems[0].Tag;
                txtFoodName.Text = food.Name;
                cboxCategories.SelectedValue = food.CategoryId;
                cboxUnit.SelectedValue = food.UnitId;
                nudCalory.Value = (decimal)food.CaloryPerUnit;
                FillPictureBox(food.Id);

            }
        }

        private void AdminAddFood_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Yemek Ekle";
            Clear();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog.ShowDialog();
            foodpic.ImageLocation = openFileDialog.FileName;
        }
        private void FillCbox()
        {
            List<Category> categories = dbbl.CategoryBL.GetAll();
            cboxCategories.DisplayMember = "Name";
            cboxCategories.ValueMember = "Id";
            cboxCategories.DataSource = categories;

            List<Unit> units = dbbl.UnitBL.GetAll();
            cboxUnit.DisplayMember = "Description";
            cboxUnit.ValueMember = "Name";
            cboxUnit.DataSource = units;
        }
        private void Clear()
        {
            txtFoodName.Clear();
            nudCalory.Value = default;
            cboxCategories.SelectedIndex = 0;
            cboxUnit.SelectedIndex = 0;
            foodpic.ImageLocation = null;
        }

        private void FillPictureBox(int foodId)
        {
            Food food = dbbl.FoodBL.Find(foodId);
            foodpic.Image = Image.FromFile(food.Image);
        }
        private void FillListView()
        {
            lviewFood.Items.Clear();
            List<Food> foods = dbbl.FoodBL.GetAll();
            foreach (Food item in foods)
            {
                ListViewItem lb = new ListViewItem();
                lb.Text = item.Name;

                Category category = dbbl.CategoryBL.Find(item.CategoryId);
                lb.SubItems.Add(category.Name);

                Unit unit = dbbl.UnitBL.FindByMeal(item.UnitId);

                if (unit.Name == UnitType.gr)
                {
                    lb.SubItems.Add("Gram");
                }
                else if (unit.Name == UnitType.lt)
                {
                    lb.SubItems.Add("Litre");
                }
                else if (unit.Name == UnitType.Adet)
                {
                    lb.SubItems.Add("Adet");
                }
                else if (unit.Name == UnitType.Porsiyon)
                {
                    lb.SubItems.Add("Porsiyon");
                }

                lb.SubItems.Add(item.CaloryPerUnit.ToString() + " kcal");
                lb.Tag = item;
                lviewFood.Items.Add(lb);
            }
        }
    }
}
