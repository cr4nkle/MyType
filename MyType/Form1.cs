using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicClass;

namespace MyType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.textBox1.ToString();
            textBox2.Text = Properties.Settings.Default.textBox2.ToString();
            textBox3.Text = Properties.Settings.Default.textBox3.ToString();
            textBox7.Text = Properties.Settings.Default.textBox7.ToString();
            textBox6.Text = Properties.Settings.Default.textBox6.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Number numb = new Number(textBox1.Text, int.Parse(textBox2.Text));
                numb = numb.Convert(int.Parse(textBox3.Text));
                textBox4.Text = numb.ToString();
                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox3 = textBox3.Text;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            try
            {
                Number numb = new Number(textBox1.Text, int.Parse(textBox2.Text));
                Number numb1 = new Number(textBox7.Text, int.Parse(textBox6.Text));
                textBox4.Text = (numb + numb1).ToString();
                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox7 = textBox7.Text;
                Properties.Settings.Default.textBox6 = textBox6.Text;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            try
            {
                Number numb = new Number(textBox1.Text, int.Parse(textBox2.Text));
                Number numb1 = new Number(textBox7.Text, int.Parse(textBox6.Text));
                textBox4.Text = (numb - numb1).ToString();
                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox7 = textBox7.Text;
                Properties.Settings.Default.textBox6 = textBox6.Text;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void buttonmult_Click(object sender, EventArgs e)
        {
            try
            {
                Number numb = new Number(textBox1.Text, int.Parse(textBox2.Text));
                Number numb1 = new Number(textBox7.Text, int.Parse(textBox6.Text));
                textBox4.Text = (numb * numb1).ToString();
                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox7 = textBox7.Text;
                Properties.Settings.Default.textBox6 = textBox6.Text;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Number numb = new Number(textBox1.Text, int.Parse(textBox2.Text));
                Number numb1 = new Number(textBox7.Text, int.Parse(textBox6.Text));
                textBox4.Text = numb.Compare(numb1);
                Properties.Settings.Default.textBox1 = textBox1.Text;
                Properties.Settings.Default.textBox2 = textBox2.Text;
                Properties.Settings.Default.textBox7 = textBox7.Text;
                Properties.Settings.Default.textBox6 = textBox6.Text;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                MessageBox.Show("Вы ввели некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
