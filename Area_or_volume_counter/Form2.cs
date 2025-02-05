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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }
        public void SetLabelText(string labelText)
        {
            ResultLabel.Text = labelText;
        }
        public void SetLabels(string labels1, string labels2, string labels3)
        {
            label1.Text = labels1;
            label2.Text = labels2;
            label3.Text = labels3;
        }

        public void setVisibleText2(bool visibleText)
        {
            textBox2.Visible = visibleText;
        }

        public void setVisibleText3(bool visibleText)
        {
            textBox3.Visible = visibleText;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            if(double.TryParse(textBox1.Text, out double value1) && double.TryParse(textBox2.Text, 
                out double value2) && double.TryParse(textBox3.Text, out double value3))
            {
                string selectedShape = ResultLabel.Text.Split(':')[0];
                switch (selectedShape)
                {
                    case "Введите радиус круга":
                        {
                            result = Math.PI * Math.Pow(value1, 2);
                            break; 
                        }
                    case "Введите длину и ширину прямоугольника":
                        {
                            result = value1 * value2;
                            break;
                        }
                    case "Введите длины сторон треугольника":
                        {
                            double p = (value1 + value2 + value3) / 2;
                            result = Math.Sqrt(p * (p - value1) * (p - value2) * (p - value3));
                            break;
                        }
                    case "Введите радиус сферы":
                        {
                            result = (4/3) * Math.PI * Math.Pow(value1, 3);
                            break;
                        }
                    case "Введите длину, ширину и высоту параллелепипеда":
                        {
                            result = value1 * value2 * value3;
                            break;
                        }
                    case "Введите радиус основания и высоту конуса":
                        {
                            result = (Math.PI * Math.Pow(value1, 2) * value2) / 3;
                            break;
                        }
                    case "Введите радиус основания и высоту цилиндра":
                        {
                            result = Math.PI * Math.Pow(value1, 2) * value2;
                            break;
                        }
                    case "Введите площадь основания и длину пирамиды":
                        {
                            result = (value1*value2) / 3;
                            break;
                        }
                }
                MessageBox.Show($"Результат: {result}", "Результат");
            }
        }
    }
}
