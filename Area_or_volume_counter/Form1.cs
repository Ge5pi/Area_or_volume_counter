using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_or_volume_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2D.Checked = true;
            comboBox2D.Items.AddRange(new string[] { "Круг", "Прямоугольник", "Треугольник"});
            comboBox3D.Items.AddRange(new string[] { "Сфера", "Пареллелепипед", "Конус", "Цилиндр", "Пирамида"});
        }

        private void radioButton2D_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2D.Checked)
            {
                comboBox3D.Visible= false;
                comboBox2D.Visible= true;
            }
        }

        private void radioButton3D_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2D.Visible = false;
            comboBox3D.Visible= true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Form2 resultForm = new Form2();
            if (radioButton2D.Checked)
            {
                string selectedShape = comboBox2D.SelectedItem.ToString();
                switch (selectedShape)
                {
                    case "Круг":
                        resultForm.SetLabelText("Введите радиус круга:");
                        resultForm.SetLabels("Радиус", "", "");
                        resultForm.setVisibleText2(false);
                        resultForm.setVisibleText3(false);
                        break;
                    case "Прямоугольник":
                        resultForm.SetLabelText("Введите длину и ширину прямоугольника:");
                        resultForm.SetLabels("Длина", "Ширина", "");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(false);
                        break;
                    case "Треугольник":
                        resultForm.SetLabelText("Введите длины сторон треугольника:");
                        resultForm.SetLabels("а", "b", "c");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(true);
                        break;
                }   
            }
            else if (radioButton3D.Checked)
            {
                string selectedShape = comboBox3D.SelectedItem.ToString();
                switch (selectedShape)
                {
                    case "Сфера":
                        resultForm.SetLabelText("Введите радиус сферы:");
                        resultForm.SetLabels("Радиус", "", "");
                        resultForm.setVisibleText2(false);
                        resultForm.setVisibleText3(false);
                        break;
                    case "Параллелепипед":
                        resultForm.SetLabelText("Введите длину и ширину и высоту параллелепипеда:");
                        resultForm.SetLabels("Длина", "Ширина", "Высота");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(true);
                        break;
                    case "Конус":
                        resultForm.SetLabelText("Введите радиус основания и высоту конуса:");
                        resultForm.SetLabels("Радиус основания", "Высота", "");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(false);
                        break;
                    case "Цилиндр":
                        resultForm.SetLabelText("Введите радиус основания и высоту цилиндра:");
                        resultForm.SetLabels("Радиус основания", "Высота", "");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(false);
                        break;
                    case "Пирамида":
                        resultForm.SetLabelText("Введите площадь основания и длину пирамиды:");
                        resultForm.SetLabels("Площадь основания", "Длина", "");
                        resultForm.setVisibleText2(true);
                        resultForm.setVisibleText3(false);
                        break;
                }
            }
            resultForm.ShowDialog();
        }
    }
}
