namespace UI_Layer
{
    partial class UserPage
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
            lblAdSoyad = new Label();
            lblKilo = new Label();
            lblBoy = new Label();
            label19 = new Label();
            label18 = new Label();
            lviewGunluk = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            chboxKahvalti = new CheckBox();
            chboxOgle = new CheckBox();
            chboxAksam = new CheckBox();
            chboxAraOgun = new CheckBox();
            btnDownDay = new Button();
            btnUpDay = new Button();
            btnToday = new Button();
            lblTotalCalory = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTargetCalory = new Label();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Location = new Point(93, 51);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(338, 20);
            lblAdSoyad.TabIndex = 67;
            lblAdSoyad.Text = "kullanıcı adı soyadı";
            lblAdSoyad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(346, 100);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(39, 15);
            lblKilo.TabIndex = 66;
            lblKilo.Text = "80 cm";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(198, 100);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(45, 15);
            lblBoy.TabIndex = 65;
            lblBoy.Text = "180 cm";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(298, 100);
            label19.Name = "label19";
            label19.Size = new Size(30, 15);
            label19.TabIndex = 64;
            label19.Text = "Kilo:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(159, 100);
            label18.Name = "label18";
            label18.Size = new Size(33, 15);
            label18.TabIndex = 63;
            label18.Text = "Boy: ";
            // 
            // lviewGunluk
            // 
            lviewGunluk.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lviewGunluk.GridLines = true;
            lviewGunluk.Location = new Point(93, 220);
            lviewGunluk.Name = "lviewGunluk";
            lviewGunluk.Size = new Size(338, 210);
            lviewGunluk.TabIndex = 68;
            lviewGunluk.UseCompatibleStateImageBehavior = false;
            lviewGunluk.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemek";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet/Porsiyon";
            columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Öğün";
            columnHeader4.Width = 100;
            // 
            // chboxKahvalti
            // 
            chboxKahvalti.AutoSize = true;
            chboxKahvalti.Checked = true;
            chboxKahvalti.CheckState = CheckState.Checked;
            chboxKahvalti.Location = new Point(80, 184);
            chboxKahvalti.Name = "chboxKahvalti";
            chboxKahvalti.Size = new Size(68, 19);
            chboxKahvalti.TabIndex = 69;
            chboxKahvalti.Text = "Kahvaltı";
            chboxKahvalti.UseVisualStyleBackColor = true;
            chboxKahvalti.CheckedChanged += chboxKahvalti_CheckedChanged;
            // 
            // chboxOgle
            // 
            chboxOgle.AutoSize = true;
            chboxOgle.Checked = true;
            chboxOgle.CheckState = CheckState.Checked;
            chboxOgle.Location = new Point(154, 184);
            chboxOgle.Name = "chboxOgle";
            chboxOgle.Size = new Size(93, 19);
            chboxOgle.TabIndex = 70;
            chboxOgle.Text = "Öğle Yemeği";
            chboxOgle.UseVisualStyleBackColor = true;
            chboxOgle.CheckedChanged += chboxOgle_CheckedChanged;
            // 
            // chboxAksam
            // 
            chboxAksam.AutoSize = true;
            chboxAksam.Checked = true;
            chboxAksam.CheckState = CheckState.Checked;
            chboxAksam.Location = new Point(253, 184);
            chboxAksam.Name = "chboxAksam";
            chboxAksam.Size = new Size(104, 19);
            chboxAksam.TabIndex = 71;
            chboxAksam.Text = "Akşam Yemeği";
            chboxAksam.UseVisualStyleBackColor = true;
            chboxAksam.CheckedChanged += chboxAksam_CheckedChanged;
            // 
            // chboxAraOgun
            // 
            chboxAraOgun.AutoSize = true;
            chboxAraOgun.Checked = true;
            chboxAraOgun.CheckState = CheckState.Checked;
            chboxAraOgun.Location = new Point(363, 184);
            chboxAraOgun.Name = "chboxAraOgun";
            chboxAraOgun.Size = new Size(77, 19);
            chboxAraOgun.TabIndex = 72;
            chboxAraOgun.Text = "Ara Öğün";
            chboxAraOgun.UseVisualStyleBackColor = true;
            chboxAraOgun.CheckedChanged += chboxAraOgun_CheckedChanged;
            // 
            // btnDownDay
            // 
            btnDownDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownDay.Location = new Point(24, 270);
            btnDownDay.Name = "btnDownDay";
            btnDownDay.Size = new Size(50, 133);
            btnDownDay.TabIndex = 73;
            btnDownDay.Text = "<=";
            btnDownDay.UseVisualStyleBackColor = true;
            btnDownDay.Click += btnDownDay_Click;
            // 
            // btnUpDay
            // 
            btnUpDay.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpDay.Location = new Point(453, 270);
            btnUpDay.Name = "btnUpDay";
            btnUpDay.Size = new Size(50, 133);
            btnUpDay.TabIndex = 74;
            btnUpDay.Text = "=>";
            btnUpDay.UseVisualStyleBackColor = true;
            btnUpDay.Click += btnUpDay_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(189, 436);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(144, 31);
            btnToday.TabIndex = 75;
            btnToday.Text = "Bugün";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // lblTotalCalory
            // 
            lblTotalCalory.AutoSize = true;
            lblTotalCalory.Location = new Point(312, 129);
            lblTotalCalory.Name = "lblTotalCalory";
            lblTotalCalory.Size = new Size(45, 15);
            lblTotalCalory.TabIndex = 77;
            lblTotalCalory.Text = "180 cm";
            // 
            // label2
            // 
            label2.Location = new Point(145, 129);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 76;
            label2.Text = "Toplam Alınan Kalori:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 155);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 78;
            label1.Text = "Günlük İhtiyacım Olan Kalori:";
            // 
            // lblTargetCalory
            // 
            lblTargetCalory.AutoSize = true;
            lblTargetCalory.Location = new Point(313, 155);
            lblTargetCalory.Name = "lblTargetCalory";
            lblTargetCalory.Size = new Size(45, 15);
            lblTargetCalory.TabIndex = 79;
            lblTargetCalory.Text = "180 cm";
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 495);
            Controls.Add(lblTargetCalory);
            Controls.Add(label1);
            Controls.Add(lblTotalCalory);
            Controls.Add(label2);
            Controls.Add(btnToday);
            Controls.Add(btnUpDay);
            Controls.Add(btnDownDay);
            Controls.Add(chboxAraOgun);
            Controls.Add(chboxAksam);
            Controls.Add(chboxOgle);
            Controls.Add(chboxKahvalti);
            Controls.Add(lviewGunluk);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(label19);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdSoyad;
        private Label lblKilo;
        private Label lblBoy;
        private Label label19;
        private Label label18;
        private ListView lviewGunluk;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private CheckBox chboxKahvalti;
        private CheckBox chboxOgle;
        private CheckBox chboxAksam;
        private CheckBox chboxAraOgun;
        private Button btnDownDay;
        private Button btnUpDay;
        private Button btnToday;
        private Label lblTotalCalory;
        private Label label2;
        private Label label1;
        private Label lblTargetCalory;
    }
}