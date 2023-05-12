using BusinessLayer.ContextBL;
using DataAccessLayer.Context;
using EntitiyLayer.Entities;
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
    public partial class UserInformationForm : Form
    {
        public UserInformationForm(int id)
        {
            InitializeComponent();
            userId = id;
            dbbl = new();
        }
        int userId;
        Team4ContextBL dbbl;
        private void UserInformationForm_Load(object sender, EventArgs e)
        {
            User user = dbbl.UserBL.Find(userId);
            nudHeight.Value = (decimal)user.Height;
            nudWeight.Value = (decimal)user.Weight;

            FillCbox();

            cboxGoal.SelectedItem = user.GoalTypeId;
            cboxLifeStyle.SelectedItem = user.LifeStyleId;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = dbbl.UserBL.Find(userId);
            user.Weight = (double)nudWeight.Value;
            user.Height = (double)nudHeight.Value;

            LifeStyleType lifeId = (LifeStyleType)cboxLifeStyle.SelectedValue;
            GoalType goalType = (GoalType)cboxGoal.SelectedValue;

            user.GoalTypeId = goalType;
            user.LifeStyleId = lifeId;

            bool isUpdated = dbbl.UserBL.Update(user);
            if(isUpdated)
            {
                MessageBox.Show("Bilgileriniz güncellendi");
            }
            else
            {
                MessageBox.Show("Bilgiler güncellenirken bir hata oluştu");
            }
        }

        private void FillCbox()
        {
            List<LifeStyle> lifeStyles = dbbl.LifeStyleBL.GetAll();
            cboxLifeStyle.DisplayMember = "Description";
            cboxLifeStyle.ValueMember = "Type";
            cboxLifeStyle.DataSource = lifeStyles;

            List<Goal> goals = dbbl.GoalBL.GetAll();
            cboxGoal.DisplayMember = "Description";
            cboxGoal.ValueMember = "GoalType";
            cboxGoal.DataSource = goals;
        }

        private void llabelUpdPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewPassword newPassword = new NewPassword(userId);
            this.Hide();
            newPassword.ShowDialog();

        }
    }
}
