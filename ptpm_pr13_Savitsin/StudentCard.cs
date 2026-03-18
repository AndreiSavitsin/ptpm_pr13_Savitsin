using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptpm_pr9_Savitsin
{
    public partial class StudentCard : Form
    {
        int idStud;
        string[] studentsInfo;
        public StudentCard(int id)
        {
            InitializeComponent();
            idStud = id;
            LoadCurrentStudent();
        }
        private void StudentCard_Load(object sender, EventArgs e)
        {
            LoadCurrentStudent();
        }
        private void LoadCurrentStudent()
        {
            try
            {
                if (idStud >= 0 && idStud < ClassStudents.ListStudents.Count)
                {
                    studentsInfo = ClassStudents.ListStudents[idStud].Split(";");

                    if (studentsInfo.Length >= 2)
                    {
                        studName.Text = studentsInfo[0] + ";" + studentsInfo[1];
                    }
                    if (studentsInfo.Length > 2 && studentsInfo[2] != "")
                    {
                        textBoxAdress.Text = studentsInfo[2];
                    }
                    else
                    {
                        textBoxAdress.Text = "";
                    }
                    if (studentsInfo.Length > 3 && studentsInfo[3] != "")
                    {
                        maskedTextBoxPhone.Text = studentsInfo[3];
                    }
                    else
                    {
                        maskedTextBoxPhone.Text = "+7 (   )    -";
                    }
                    if (studentsInfo.Length > 4 && studentsInfo[4] != "")
                    {
                        dateBorn.Text = studentsInfo[4];
                    }
                    if (studentsInfo.Length > 5 && studentsInfo[5] != "")
                    {
                        textBoxPhoto.Text = studentsInfo[5];
                    }
                    else
                    {
                        textBoxPhoto.Text = "";
                    }
                    if (textBoxPhoto.Text == "")
                    {
                        pbPhoto.Image = null;
                    }
                    else
                    {
                        pbPhoto.Image = Image.FromFile($@"img\{textBoxPhoto.Text}");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e) //Кнопка добавить фото
        {
            openFileDialog1.Filter = "Изображения (*.jpg, *.png, *.bmp, *.gif)|*.jpg, *.png, *.bmp, *.gif|Все файлы (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourcePath = openFileDialog1.FileName;
                    string extension = Path.GetExtension(sourcePath);

                    string newFileName = $"{studentsInfo[0]}_{studentsInfo[1]}{extension}";
                    string targetPath = $@"img\{newFileName}";

                    Directory.CreateDirectory(Path.GetDirectoryName(targetPath));

                    File.Copy(sourcePath, targetPath, true);
                    textBoxPhoto.Text = newFileName;
                    pbPhoto.Image = Image.FromFile($@"img\{newFileName}");

                    MessageBox.Show("Фотография успешно загружена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e) //Кнопка сохранить
        {
            if (textBoxAdress.Text == "" || maskedTextBoxPhone.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPhoto.Text == "")
            {
                MessageBox.Show("Загрузите фото", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string info = $"{studName.Text};{textBoxAdress.Text};{maskedTextBoxPhone.Text};{dateBorn.Value};{textBoxPhoto.Text}";
                ClassStudents.ListStudents[idStud] = info;

                MessageBox.Show($"{studName.Text};{textBoxAdress.Text};{maskedTextBoxPhone.Text};{dateBorn.Value};{textBoxPhoto.Text} сохранен");
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (idStud > 0)
            {
                idStud--;
                LoadCurrentStudent();
            }
            else
            {
                MessageBox.Show("Это первый студент", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (idStud < ClassStudents.ListStudents.Count-1)
            {
                idStud++;
                LoadCurrentStudent();
            }
            else
            {
                MessageBox.Show("Это последний студент", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
