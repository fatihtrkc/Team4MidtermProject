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
using UI_Layer.Utilities;

namespace UI_Layer
{
    public partial class AdminFoodsForm : Form
    {
        public AdminFoodsForm()
        {
            InitializeComponent();
            foodbl = new();
            categorybl = new();
        }
        FoodBL foodbl;
        CategoryBL categorybl;
        private void AdminFoodsForm_Load(object sender, EventArgs e)
        {
            dtgridFoods.DataSource = foodbl.GetAll().Select(fd => new { fd.Name, fd.CaloryPerUnit, fd.CategoryId, fd.UnitId }).OrderBy(fd => fd.Name).ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = categorybl.GetAll();
            cmbUnit.Items.AddRange(Enum.GetNames(typeof(UnitType)));
            cmbUnit.SelectedIndex = 0;
            dtgridFoods.ClearSelection();
            Helper.ButtonSituation(this.Controls, false, false);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            if (txtName.Text.Length > 1 && txtName.Text.Length != 50)
                lblNameCharacter.Text = $"{txtName.Text.Length} characters used )";
            else if (txtName.Text.Length == 50)
                lblNameCharacter.Text = $"{txtName.Text.Length} characters used is max )";
            else lblNameCharacter.Text = $"{txtName.Text.Length} character used )";

            if (foodIndex > -1 && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                Helper.ButtonSituation(this.Controls, true, true);
            }
            else if (foodIndex == -1 && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                Helper.ButtonSituation(this.Controls, false, true);
            }
            else if (foodIndex > -1 && string.IsNullOrWhiteSpace(txtName.Text))
            {
                Helper.ButtonSituation(this.Controls, true, false);
            }
            else if (foodIndex == -1 && string.IsNullOrWhiteSpace(txtName.Text))
            {
                Helper.ButtonSituation(this.Controls, false, false);
            }
            TextChangeAlert();
        }

        Food food;
        string foodName;
        int foodIndex = -1;
        private void dtgridFoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodIndex = e.RowIndex;
            if (foodIndex != -1)
            {
                foodName = dtgridFoods.Rows[foodIndex].Cells[0].Value.ToString();

                food = foodbl.GetByText(foodName).FirstOrDefault();
                if (food is not null)
                {
                    txtName.Text = food.Name;
                    Category category = categorybl.Find(food.CategoryId);
                    cmbCategory.Text = category.Name;
                    nmrcCalory.Value = (decimal)(food.CaloryPerUnit);
                    cmbUnit.Text = food.UnitId.ToString();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (foodIndex == -1 && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                food = new();
                food.Name = txtName.Text;
                food.CategoryId = (int)(cmbCategory.SelectedValue);
                food.CaloryPerUnit = (double)(nmrcCalory.Value);
                food.UnitId = (UnitType)Enum.Parse(typeof(UnitType), cmbUnit.SelectedItem.ToString());

                DialogResult dr = MessageBox.Show($"{txtName.Text} adında yeni bir besin oluşturma işlemini onaylıyor musunuz?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool IsAdded = foodbl.Add(food);
                    if (IsAdded)
                    {
                        MessageBox.Show("Ekleme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgridFoods.DataSource = foodbl.GetAll().Select(fd => new { fd.Name, fd.CaloryPerUnit, fd.CategoryId, fd.UnitId }).OrderBy(fd => fd.Name).ToList();
                        Helper.WriteSelectClear(this.Controls);
                    }
                    else MessageBox.Show("Ekleme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (food is not null)
            {
                DialogResult dr = MessageBox.Show($"{food.Name} adlı besini silmek istiyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    bool IsDeleted = foodbl.Delete(food.Id);
                    if (IsDeleted)
                    {
                        MessageBox.Show("Silme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgridFoods.DataSource = foodbl.GetAll().Select(fd => new { fd.Name, fd.CaloryPerUnit, fd.CategoryId, fd.UnitId }).OrderBy(fd => fd.Name).ToList();
                        Helper.WriteSelectClear(this.Controls);
                    }
                    else MessageBox.Show("Silme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (food is not null)
            {
                DialogResult dr = MessageBox.Show($"{food.Name} adlı besinin adını {txtName.Text} olarak değiştirme işlemini onaylıyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    food = foodbl.Find(food.Id);
                    food.Name = txtName.Text;
                    food.CategoryId = (int)(cmbCategory.SelectedValue);
                    food.CaloryPerUnit = (double)(nmrcCalory.Value);
                    food.UnitId = (UnitType)(Enum.Parse(typeof(UnitType), cmbUnit.SelectedItem.ToString()));

                    bool IsUpdated = foodbl.Update(food);
                    if (IsUpdated)
                    {
                        MessageBox.Show("Güncelleme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dtgridFoods.DataSource = foodbl.GetAll().Select(fd => new { fd.Name, fd.CaloryPerUnit, fd.CategoryId, fd.UnitId }).OrderBy(fd => fd.Name).ToList();
                        Helper.WriteSelectClear(this.Controls);
                    }
                    else MessageBox.Show("Güncelleme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int counter = 0;
        void TextChangeAlert()
        {
            if (txtName.Text.Length == 50)
            {
                timer.Start();
                pctrbxAlert.Visible = true;
            }
            else
            {
                timer.Stop();
                counter = 0;
                pctrbxAlert.Visible = false;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter % 3 != 0) pctrbxAlert.Visible = true;
            else pctrbxAlert.Visible = false;
        }
        private void AdminFoodsForm_Click(object sender, EventArgs e)
        {
            Helper.WriteSelectClear(this.Controls);
            foodIndex = -1;
        }

        private void pctrbxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pctrbxExit_MouseHover(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = Color.LightCoral;
        }
        private void pctrbxExit_MouseLeave(object sender, EventArgs e)
        {
            pctrbxExit.BackColor = default;
        }

    }
}
