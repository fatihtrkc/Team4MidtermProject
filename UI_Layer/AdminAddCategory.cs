using BusinessLayer.ContextBL;
using EntitiyLayer.Entities;
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
    public partial class AdminAddCategory : Form
    {
        public AdminAddCategory()
        {
            InitializeComponent();
            dbbl = new();
        }
        Team4ContextBL dbbl;
        private void AdminAddCategory_Load(object sender, EventArgs e)
        {
            FillListView();
        }



        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lviewCategory.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogResult == DialogResult.Yes)
                {
                    Category category = (Category)lviewCategory.SelectedItems[0].Tag;
                    bool isDeleted = dbbl.CategoryBL.Delete(category.Id);
                    if (isDeleted)
                    {
                        MessageBox.Show("Kategori silindi!");

                    }
                    else
                    {
                        MessageBox.Show("Kategori silinemedi!");
                    }
                    FillListView();
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Kategori adı boş bırakılamaz. Lütfen önce kategori ismini girin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (btnAdd.Text == "Güncelle")
                {
                    Category category = (Category)lviewCategory.SelectedItems[0].Tag;
                    category.Name = txtCategoryName.Text;
                    bool isupdated = dbbl.CategoryBL.Update(category);
                    if (isupdated)
                    {
                        MessageBox.Show("Kategori güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Kategori güncellenemedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Category category = new Category();
                    category.Name = txtCategoryName.Text;
                    dbbl.CategoryBL.Add(category);

                }
                FillListView();
            }

        }
        private void FillListView()
        {
            lviewCategory.Items.Clear();
            List<Category> list = dbbl.CategoryBL.GetAll();
            foreach (Category item in list)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = item.Name;
                lv.Tag = item;
                lviewCategory.Items.Add(lv);
            }
            txtCategoryName.Clear();
        }

        private void lviewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Güncelle";
            if (lviewCategory.SelectedItems.Count > 0)
            {

                Category category = (Category)lviewCategory.SelectedItems[0].Tag;
                txtCategoryName.Text = category.Name;
            }
        }

        private void AdminAddCategory_Click(object sender, EventArgs e)
        {
            txtCategoryName.Clear();
            btnAdd.Text = "Kategori Ekle";
        }
    }
}
