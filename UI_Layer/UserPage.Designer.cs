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
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Location = new Point(169, 63);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(143, 20);
            lblAdSoyad.TabIndex = 67;
            lblAdSoyad.Text = "kullanıcı adı soyadı";
            lblAdSoyad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Location = new Point(282, 103);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(39, 15);
            lblKilo.TabIndex = 66;
            lblKilo.Text = "80 cm";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Location = new Point(169, 104);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(45, 15);
            lblBoy.TabIndex = 65;
            lblBoy.Text = "180 cm";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(234, 104);
            label19.Name = "label19";
            label19.Size = new Size(30, 15);
            label19.TabIndex = 64;
            label19.Text = "Kilo:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(130, 103);
            label18.Name = "label18";
            label18.Size = new Size(33, 15);
            label18.TabIndex = 63;
            label18.Text = "Boy: ";
            // 
            // lviewGunluk
            // 
            lviewGunluk.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lviewGunluk.GridLines = true;
            lviewGunluk.Location = new Point(80, 220);
            lviewGunluk.Name = "lviewGunluk";
            lviewGunluk.Size = new Size(378, 210);
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
            chboxKahvalti.Location = new Point(80, 184);
            chboxKahvalti.Name = "chboxKahvalti";
            chboxKahvalti.Size = new Size(68, 19);
            chboxKahvalti.TabIndex = 69;
            chboxKahvalti.Text = "Kahvaltı";
            chboxKahvalti.UseVisualStyleBackColor = true;
            // 
            // chboxOgle
            // 
            chboxOgle.AutoSize = true;
            chboxOgle.Location = new Point(154, 184);
            chboxOgle.Name = "chboxOgle";
            chboxOgle.Size = new Size(93, 19);
            chboxOgle.TabIndex = 70;
            chboxOgle.Text = "Öğle Yemeği";
            chboxOgle.UseVisualStyleBackColor = true;
            // 
            // chboxAksam
            // 
            chboxAksam.AutoSize = true;
            chboxAksam.Location = new Point(253, 184);
            chboxAksam.Name = "chboxAksam";
            chboxAksam.Size = new Size(104, 19);
            chboxAksam.TabIndex = 71;
            chboxAksam.Text = "Akşam Yemeği";
            chboxAksam.UseVisualStyleBackColor = true;
            // 
            // chboxAraOgun
            // 
            chboxAraOgun.AutoSize = true;
            chboxAraOgun.Location = new Point(363, 184);
            chboxAraOgun.Name = "chboxAraOgun";
            chboxAraOgun.Size = new Size(77, 19);
            chboxAraOgun.TabIndex = 72;
            chboxAraOgun.Text = "Ara Öğün";
            chboxAraOgun.UseVisualStyleBackColor = true;
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
            btnUpDay.Location = new Point(464, 270);
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
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 495);
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
    }
}