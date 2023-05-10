using BusinessLayer.EntitiesBL;
using EntityLayer.Entities;
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
    public partial class AdminCategoriesForm : Form
    {
        public AdminCategoriesForm()
        {
            InitializeComponent();
            categorybl = new();
        }
        CategoryBL categorybl;
        private void AdminCategoriesForm_Load(object sender, EventArgs e)
        {
            dtgridCategory.DataSource = categorybl.GetAll().Select(ctgry => new { ctgry.Id, ctgry.Name }).OrderBy(ctgry => ctgry.Id).ToList();
            dtgridCategory.ClearSelection();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtName.Text))
            {
                category = new();
                category.Name = txtName.Text;

                if (category is not null)
                {
                    DialogResult dr = MessageBox.Show($"{txtName.Text} adında yeni bir kategori oluşturma işlemini onaylıyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        bool IsAdded = categorybl.Add(category);
                        if (IsAdded)
                        {
                            MessageBox.Show("Ekleme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtgridCategory.DataSource = categorybl.GetAll().Select(ctgry => new { ctgry.Id, ctgry.Name }).OrderBy(ctgry => ctgry.Id).ToList();
                            dtgridCategory.ClearSelection();
                            txtName.Clear();
                        }
                        else MessageBox.Show("Silme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        Category category;
        int categoryId;
        private void dtgridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                categoryId = (int)(dtgridCategory.Rows[e.RowIndex].Cells[0].Value);

                category = categorybl.Find(categoryId);
                if (category is not null)
                {
                    txtId.Text = category.Id.ToString();
                    txtName.Text = category.Name;
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (category is not null)
            {
                DialogResult dr = MessageBox.Show($"{category.Id} Id' ye sahip {category.Name} kategorisini silmek istiyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    bool IsDeleted = categorybl.Delete(categoryId);
                    if (IsDeleted)
                    {
                        MessageBox.Show("Silme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgridCategory.DataSource = categorybl.GetAll().Select(ctgry => new { ctgry.Id, ctgry.Name }).OrderBy(ctgry => ctgry.Id).ToList();
                        dtgridCategory.ClearSelection();
                        txtId.Clear();
                        txtName.Clear();
                    }
                    else MessageBox.Show("Silme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (category is not null)
            {
                DialogResult dr = MessageBox.Show($"{category.Id} Id ve {category.Name} adlı kategorinin adını {txtName.Text} olarak değiştirme işlemini onaylıyor musunuz?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    category = categorybl.Find(categoryId);
                    category.Name = txtName.Text;
                    bool IsUpdated = categorybl.Update(category);
                    if (IsUpdated)
                    {
                        MessageBox.Show("Güncelleme işlemi başarılı !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtgridCategory.DataSource = categorybl.GetAll().Select(ctgry => new { ctgry.Id, ctgry.Name }).ToList();
                        dtgridCategory.ClearSelection();
                        txtId.Clear();
                        txtName.Clear();
                    }
                    else MessageBox.Show("Silme işlemi tamamlanamadı, lütfen daha sonra tekrar deneyiniz !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dtgridCategory.ClearSelection();
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
