namespace ptpm_pr9_Savitsin
{
    partial class StudentCard
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
            btnSaveInfo = new Button();
            studName = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            btnAddPhoto = new Button();
            textBoxPhoto = new TextBox();
            label7 = new Label();
            pbPhoto = new PictureBox();
            label6 = new Label();
            dateBorn = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            textBoxAdress = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            btnLeft = new Button();
            btnRight = new Button();
            ((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
            SuspendLayout();
            // 
            // btnSaveInfo
            // 
            btnSaveInfo.Location = new Point(559, 355);
            btnSaveInfo.Name = "btnSaveInfo";
            btnSaveInfo.Size = new Size(114, 23);
            btnSaveInfo.TabIndex = 65;
            btnSaveInfo.Text = "Сохранить";
            btnSaveInfo.UseVisualStyleBackColor = true;
            btnSaveInfo.Click += btnSaveInfo_Click;
            // 
            // studName
            // 
            studName.AutoSize = true;
            studName.Location = new Point(98, 56);
            studName.Name = "studName";
            studName.Size = new Size(93, 15);
            studName.TabIndex = 64;
            studName.Text = "Фамилия и имя";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(98, 238);
            maskedTextBoxPhone.Mask = "+7 (000) 000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(200, 23);
            maskedTextBoxPhone.TabIndex = 63;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Location = new Point(559, 309);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(114, 23);
            btnAddPhoto.TabIndex = 62;
            btnAddPhoto.Text = "Добавить фото";
            btnAddPhoto.UseVisualStyleBackColor = true;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // textBoxPhoto
            // 
            textBoxPhoto.Enabled = false;
            textBoxPhoto.Location = new Point(559, 269);
            textBoxPhoto.Name = "textBoxPhoto";
            textBoxPhoto.Size = new Size(197, 23);
            textBoxPhoto.TabIndex = 61;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(559, 238);
            label7.Name = "label7";
            label7.Size = new Size(156, 15);
            label7.TabIndex = 60;
            label7.Text = "Введите имя файла c фото:";
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(559, 56);
            pbPhoto.Name = "pbPhoto";
            pbPhoto.Size = new Size(197, 154);
            pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPhoto.TabIndex = 59;
            pbPhoto.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 277);
            label6.Name = "label6";
            label6.Size = new Size(148, 15);
            label6.TabIndex = 58;
            label6.Text = "Выберите дату рождения:";
            // 
            // dateBorn
            // 
            dateBorn.Location = new Point(98, 309);
            dateBorn.Name = "dateBorn";
            dateBorn.Size = new Size(200, 23);
            dateBorn.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 209);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 56;
            label5.Text = "Введите номер телефона:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 100);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 55;
            label4.Text = "Введите адрес:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(98, 136);
            textBoxAdress.Multiline = true;
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(200, 53);
            textBoxAdress.TabIndex = 54;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(376, 52);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(40, 23);
            btnLeft.TabIndex = 66;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(433, 52);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(40, 23);
            btnRight.TabIndex = 67;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // StudentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnSaveInfo);
            Controls.Add(studName);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(btnAddPhoto);
            Controls.Add(textBoxPhoto);
            Controls.Add(label7);
            Controls.Add(pbPhoto);
            Controls.Add(label6);
            Controls.Add(dateBorn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxAdress);
            Name = "StudentCard";
            Text = "StudentCard";
            ((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveInfo;
        private Label studName;
        private MaskedTextBox maskedTextBoxPhone;
        private Button btnAddPhoto;
        private TextBox textBoxPhoto;
        private Label label7;
        private PictureBox pbPhoto;
        private Label label6;
        private DateTimePicker dateBorn;
        private Label label5;
        private Label label4;
        private TextBox textBoxAdress;
        private OpenFileDialog openFileDialog1;
        private Button btnLeft;
        private Button btnRight;
    }
}