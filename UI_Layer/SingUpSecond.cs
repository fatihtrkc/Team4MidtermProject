using BusinessLayer.ContextBL;
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
    public partial class SingUpSecond : Form
    {
        public SingUpSecond(string Name, string Surname, string Mail, string Password, string Speque, string Answer, DateTime DateTime)
        {
            InitializeComponent();
            name = Name;
            surname = Surname;
            email = Mail;
            password = Password;
            speque = Speque;
            answer = Answer;
            dateTime = DateTime;
            dbbll = new();
        }
        string name, surname, email, password, speque, answer;
        DateTime dateTime;
        Team4ContextBL dbbll;
        User user;
        private void SingUpSecond_Load(object sender, EventArgs e)
        {
            List<LifeStyle> lifeStyles = dbbll.LifeStyleBL.GetAll();
            cboxLifeStyle.DisplayMember = "Description";
            cboxLifeStyle.ValueMember = "Type";
            cboxLifeStyle.DataSource = lifeStyles;

            List<Goal> goals = dbbll.GoalBL.GetAll();
            cboxGoal.DisplayMember = "Description";
            cboxGoal.ValueMember = "GoalType";
            cboxGoal.DataSource = goals;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {

                        MessageBox.Show("Tüm veriler girilmelidir");
                        return;
                    }
                }
            }
            user = new User();
            LifeStyleType lifeId = (LifeStyleType)cboxLifeStyle.SelectedValue;
            GoalType goalType = (GoalType)cboxGoal.SelectedValue;
            user.Name = name.ToUpper();
            user.Surname = surname.ToUpper();
            user.Email = email;
            user.Password = password;
            user.SpecificQuestion = speque;
            user.QuestionAnswer = answer.ToUpper();
            user.BirthDate = dateTime;

            user.GoalTypeId = goalType;
            user.Gender = rdMale.Checked ? Gender.Male : Gender.Female;
            user.LifeStyleId = lifeId;
            user.Height = (double)nudHeight.Value;
            user.Weight = (double)nudWeight.Value;

            bool isAdded = dbbll.UserBL.Add(user);


            if (isAdded)
            {
                MessageBox.Show("Kullanıcı başarıyla oluşturuldu", "İŞLEM ONAYLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Bir hata oldu. Kullanıcı eklenemedi", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(name, surname, email, password, speque, answer, dateTime);
            this.Hide();
            signUpForm.ShowDialog();
        }
    }
}
