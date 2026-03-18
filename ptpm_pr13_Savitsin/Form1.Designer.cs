namespace ptpm_pr9_Savitsin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxSurname = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            listBox1 = new ListBox();
            btnLeft = new Button();
            btnRight = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            btnClear = new Button();
            btnSort = new Button();
            btnChange = new Button();
            error = new Label();
            label3 = new Label();
            textBoxFile = new TextBox();
            btnChangeInfo = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 41);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите Фамилию:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(100, 69);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(121, 23);
            textBoxSurname.TabIndex = 1;
            textBoxSurname.TextChanged += textBoxSurname_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 105);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите Имя:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 134);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(121, 23);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(35, 248);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(370, 244);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(100, 514);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(51, 23);
            btnLeft.TabIndex = 5;
            btnLeft.Text = "<<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(170, 514);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(51, 23);
            btnRight.TabIndex = 6;
            btnRight.Text = ">>";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(390, 40);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(98, 52);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить в файл";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(518, 40);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(98, 52);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить из файла";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(440, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(126, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(440, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(440, 229);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(126, 23);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "Вставить";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(440, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(126, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(440, 287);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(126, 23);
            btnSort.TabIndex = 14;
            btnSort.Text = "Сортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(440, 171);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(126, 23);
            btnChange.TabIndex = 15;
            btnChange.Text = "Изменить";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Location = new Point(103, 240);
            error.Name = "error";
            error.Size = new Size(0, 15);
            error.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 173);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 17;
            label3.Text = "Введите имя файла:";
            // 
            // textBoxFile
            // 
            textBoxFile.Location = new Point(100, 205);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new Size(121, 23);
            textBoxFile.TabIndex = 18;
            // 
            // btnChangeInfo
            // 
            btnChangeInfo.Location = new Point(440, 347);
            btnChangeInfo.Name = "btnChangeInfo";
            btnChangeInfo.Size = new Size(126, 49);
            btnChangeInfo.TabIndex = 19;
            btnChangeInfo.Text = "Редактировать личные данные";
            btnChangeInfo.UseVisualStyleBackColor = true;
            btnChangeInfo.Click += btnChangeInfo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 596);
            Controls.Add(btnChangeInfo);
            Controls.Add(textBoxFile);
            Controls.Add(label3);
            Controls.Add(error);
            Controls.Add(btnChange);
            Controls.Add(btnSort);
            Controls.Add(btnClear);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(listBox1);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxSurname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSurname;
        private Label label2;
        private TextBox textBoxName;
        private ListBox listBox1;
        private Button btnLeft;
        private Button btnRight;
        private Button btnSave;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnClear;
        private Button btnSort;
        private Button btnChange;
        private Label error;
        private Label label3;
        private TextBox textBoxFile;
        private Button btnChangeInfo;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
