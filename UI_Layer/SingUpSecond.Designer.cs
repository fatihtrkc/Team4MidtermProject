namespace UI_Layer
{
    partial class SingUpSecond
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
            label13 = new Label();
            cboxLifeStyle = new ComboBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            label12 = new Label();
            nudWeight = new NumericUpDown();
            nudHeight = new NumericUpDown();
            label11 = new Label();
            label8 = new Label();
            label1 = new Label();
            cboxGoal = new ComboBox();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.Location = new Point(39, 96);
            label13.Name = "label13";
            label13.Size = new Size(109, 23);
            label13.TabIndex = 56;
            label13.Text = "Hayat Biçimi";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboxLifeStyle
            // 
            cboxLifeStyle.FormattingEnabled = true;
            cboxLifeStyle.Location = new Point(175, 96);
            cboxLifeStyle.Name = "cboxLifeStyle";
            cboxLifeStyle.Size = new Size(120, 23);
            cboxLifeStyle.TabIndex = 55;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(240, 71);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(53, 19);
            rdMale.TabIndex = 54;
            rdMale.Text = "Erkek";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Checked = true;
            rdFemale.Location = new Point(175, 71);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(55, 19);
            rdFemale.TabIndex = 53;
            rdFemale.TabStop = true;
            rdFemale.Text = "Kadın";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Location = new Point(39, 69);
            label12.Name = "label12";
            label12.Size = new Size(109, 23);
            label12.TabIndex = 52;
            label12.Text = "Cinsiyet";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 1;
            nudWeight.Location = new Point(175, 161);
            nudWeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            nudWeight.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(120, 23);
            nudWeight.TabIndex = 60;
            nudWeight.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // nudHeight
            // 
            nudHeight.DecimalPlaces = 1;
            nudHeight.Location = new Point(175, 132);
            nudHeight.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudHeight.Minimum = new decimal(new int[] { 130, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(120, 23);
            nudHeight.TabIndex = 59;
            nudHeight.Value = new decimal(new int[] { 130, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Location = new Point(39, 161);
            label11.Name = "label11";
            label11.Size = new Size(109, 23);
            label11.TabIndex = 58;
            label11.Text = "Kilo";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.Location = new Point(39, 132);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 57;
            label8.Text = "Boy";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Location = new Point(42, 210);
            label1.Name = "label1";
            label1.Size = new Size(254, 50);
            label1.TabIndex = 62;
            label1.Text = "Uygulamayı Hangi Amaçla Kullanıyorsunuz?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboxGoal
            // 
            cboxGoal.FormattingEnabled = true;
            cboxGoal.Location = new Point(42, 263);
            cboxGoal.Name = "cboxGoal";
            cboxGoal.Size = new Size(256, 23);
            cboxGoal.TabIndex = 61;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 63;
            btnSave.Text = "Kayıt Ol";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(42, 318);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 64;
            btnBack.Text = "Geri Dön";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SingUpSecond
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 413);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(cboxGoal);
            Controls.Add(nudWeight);
            Controls.Add(nudHeight);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label13);
            Controls.Add(cboxLifeStyle);
            Controls.Add(rdMale);
            Controls.Add(rdFemale);
            Controls.Add(label12);
            Name = "SingUpSecond";
            Text = "SingUpSecond";
            Load += SingUpSecond_Load;
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private ComboBox cboxLifeStyle;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Label label12;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHeight;
        private Label label11;
        private Label label8;
        private Label label1;
        private ComboBox cboxGoal;
        private Button btnSave;
        private Button btnBack;
    }
}