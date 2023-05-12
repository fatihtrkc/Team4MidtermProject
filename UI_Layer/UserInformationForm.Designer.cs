namespace UI_Layer
{
    partial class UserInformationForm
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            label11 = new Label();
            label8 = new Label();
            nudWeight = new NumericUpDown();
            nudHeight = new NumericUpDown();
            label2 = new Label();
            cboxLifeStyle = new ComboBox();
            cboxGoal = new ComboBox();
            label3 = new Label();
            btnUpdate = new Button();
            llabelUpdPass = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(108, 52);
            label1.Name = "label1";
            label1.Size = new Size(169, 23);
            label1.TabIndex = 41;
            label1.Text = "Adı soyadı hoş geldin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(22, 417);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 43);
            linkLabel1.TabIndex = 39;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kişisel Bilgileri Güncelle";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Location = new Point(60, 152);
            label11.Name = "label11";
            label11.Size = new Size(101, 23);
            label11.TabIndex = 35;
            label11.Text = "Kilo";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(60, 123);
            label8.Name = "label8";
            label8.Size = new Size(101, 23);
            label8.TabIndex = 34;
            label8.Text = "Boy";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 1;
            nudWeight.Location = new Point(185, 153);
            nudWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(121, 23);
            nudWeight.TabIndex = 61;
            nudWeight.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.DecimalPlaces = 1;
            nudHeight.Location = new Point(185, 122);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(121, 23);
            nudHeight.TabIndex = 62;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // label2
            // 
            label2.Location = new Point(108, 204);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 63;
            label2.Text = "Günlük Egzersiz Sıklığı:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxLifeStyle
            // 
            cboxLifeStyle.FormattingEnabled = true;
            cboxLifeStyle.Location = new Point(108, 239);
            cboxLifeStyle.Name = "cboxLifeStyle";
            cboxLifeStyle.Size = new Size(169, 23);
            cboxLifeStyle.TabIndex = 64;
            // 
            // cboxGoal
            // 
            cboxGoal.FormattingEnabled = true;
            cboxGoal.Location = new Point(108, 307);
            cboxGoal.Name = "cboxGoal";
            cboxGoal.Size = new Size(169, 23);
            cboxGoal.TabIndex = 66;
            // 
            // label3
            // 
            label3.Location = new Point(108, 281);
            label3.Name = "label3";
            label3.Size = new Size(169, 23);
            label3.TabIndex = 65;
            label3.Text = "Uygulamayı Kullanım Amacı:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(108, 351);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(169, 46);
            btnUpdate.TabIndex = 67;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // llabelUpdPass
            // 
            llabelUpdPass.AutoSize = true;
            llabelUpdPass.Location = new Point(258, 431);
            llabelUpdPass.Name = "llabelUpdPass";
            llabelUpdPass.Size = new Size(79, 15);
            llabelUpdPass.TabIndex = 68;
            llabelUpdPass.TabStop = true;
            llabelUpdPass.Text = "Şifre Güncelle";
            llabelUpdPass.LinkClicked += llabelUpdPass_LinkClicked;
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 469);
            Controls.Add(llabelUpdPass);
            Controls.Add(btnUpdate);
            Controls.Add(cboxGoal);
            Controls.Add(label3);
            Controls.Add(cboxLifeStyle);
            Controls.Add(label2);
            Controls.Add(nudHeight);
            Controls.Add(nudWeight);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(label11);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserInformationForm";
            Text = "UserInformation";
            Load += UserInformationForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Label label11;
        private Label label8;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHeight;
        private Label label2;
        private ComboBox cboxLifeStyle;
        private ComboBox cboxGoal;
        private Label label3;
        private Button btnUpdate;
        private LinkLabel llabelUpdPass;
    }
}