namespace UI_Layer
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudHeight = new NumericUpDown();
            button1 = new Button();
            label11 = new Label();
            txtAgain = new TextBox();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtSpeAns = new TextBox();
            label5 = new Label();
            txtSpe = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtMail = new TextBox();
            label4 = new Label();
            txtSurname = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtBirth = new DateTimePicker();
            nudWeight = new NumericUpDown();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            label12 = new Label();
            cboxLifeStyle = new ComboBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            SuspendLayout();
            // 
            // nudHeight
            // 
            nudHeight.DecimalPlaces = 1;
            nudHeight.Location = new Point(174, 355);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(120, 23);
            nudHeight.TabIndex = 44;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Location = new Point(149, 428);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 43;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.Location = new Point(68, 384);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 41;
            label11.Text = "Kilo";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAgain
            // 
            txtAgain.Location = new Point(174, 239);
            txtAgain.Name = "txtAgain";
            txtAgain.Size = new Size(120, 23);
            txtAgain.TabIndex = 40;
            // 
            // label10
            // 
            label10.Location = new Point(68, 239);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 39;
            label10.Text = "Şifre Tekrarı";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(68, 355);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 38;
            label8.Text = "Boy";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Location = new Point(68, 326);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 36;
            label9.Text = "Doğum Tarihi";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSpeAns
            // 
            txtSpeAns.Location = new Point(174, 297);
            txtSpeAns.Name = "txtSpeAns";
            txtSpeAns.Size = new Size(120, 23);
            txtSpeAns.TabIndex = 35;
            // 
            // label5
            // 
            label5.Location = new Point(68, 297);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 34;
            label5.Text = "Özel Soru Cevabı";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSpe
            // 
            txtSpe.Location = new Point(174, 268);
            txtSpe.Name = "txtSpe";
            txtSpe.Size = new Size(120, 23);
            txtSpe.TabIndex = 33;
            // 
            // label6
            // 
            label6.Location = new Point(68, 268);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 32;
            label6.Text = "Özel Soru";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(120, 23);
            txtPassword.TabIndex = 31;
            // 
            // label7
            // 
            label7.Location = new Point(68, 210);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 30;
            label7.Text = "Şifre";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(174, 123);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(120, 23);
            txtMail.TabIndex = 29;
            // 
            // label4
            // 
            label4.Location = new Point(68, 123);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 28;
            label4.Text = "Mail adresi";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(174, 94);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(120, 23);
            txtSurname.TabIndex = 27;
            // 
            // label3
            // 
            label3.Location = new Point(68, 94);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 26;
            label3.Text = "Soyisim";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 25;
            // 
            // label2
            // 
            label2.Location = new Point(68, 65);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 24;
            label2.Text = "İsim";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 28);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 23;
            label1.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // dtBirth
            // 
            dtBirth.Location = new Point(174, 326);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(120, 23);
            dtBirth.TabIndex = 45;
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 1;
            nudWeight.Location = new Point(174, 384);
            nudWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(120, 23);
            nudWeight.TabIndex = 46;
            nudWeight.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Checked = true;
            rdFemale.Location = new Point(174, 156);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(55, 19);
            rdFemale.TabIndex = 48;
            rdFemale.TabStop = true;
            rdFemale.Text = "Kadın";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(239, 156);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(53, 19);
            rdMale.TabIndex = 49;
            rdMale.Text = "Erkek";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Location = new Point(68, 154);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 47;
            label12.Text = "Cinsiyet";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxLifeStyle
            // 
            cboxLifeStyle.FormattingEnabled = true;
            cboxLifeStyle.Location = new Point(174, 181);
            cboxLifeStyle.Name = "cboxLifeStyle";
            cboxLifeStyle.Size = new Size(120, 23);
            cboxLifeStyle.TabIndex = 50;
            // 
            // label13
            // 
            label13.Location = new Point(68, 181);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 51;
            label13.Text = "Hayat Biçimi";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 461);
            Controls.Add(label13);
            Controls.Add(cboxLifeStyle);
            Controls.Add(rdMale);
            Controls.Add(rdFemale);
            Controls.Add(label12);
            Controls.Add(nudWeight);
            Controls.Add(dtBirth);
            Controls.Add(nudHeight);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(txtAgain);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtSpeAns);
            Controls.Add(label5);
            Controls.Add(txtSpe);
            Controls.Add(label6);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(txtSurname);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "Signin";
            Load += SignUpForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudHeight;
        private Button button1;
        private Label label11;
        private TextBox txtAgain;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox txtSpeAns;
        private Label label5;
        private TextBox txtSpe;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtSurname;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private DateTimePicker dtBirth;
        private NumericUpDown nudWeight;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Label label12;
        private ComboBox cboxLifeStyle;
        private Label label13;
    }
}