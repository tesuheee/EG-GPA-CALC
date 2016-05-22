using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA計算機
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
            MaximizeBox = false;
            for (int i = 0; i <= 20; i++)
			{
				comboBox1.Items.Add(i);
				comboBox2.Items.Add(i);
				comboBox3.Items.Add(i);
				comboBox4.Items.Add(i);
				comboBox5.Items.Add(i);
			}
			ActiveControl = comboBox1;
			comboBox1.TabIndex = 0;
			comboBox2.TabIndex = 1;
			comboBox3.TabIndex = 2;
			comboBox4.TabIndex = 3;
			comboBox5.TabIndex = 4;
			button1.TabIndex = 5;

			button1.Enabled = false;
            button2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int s = (int)comboBox1.SelectedItem;
			int a = (int)comboBox2.SelectedItem;
			int b = (int)comboBox3.SelectedItem;
			int c = (int)comboBox4.SelectedItem;
			int d = (int)comboBox5.SelectedItem;
			double get = s*4 + a*3 + b*2 + c*1;
			double sum = s + a + b + c + d;
			double gpa = get / sum;
			Decimal result = Math.Round((Decimal)gpa, 2, MidpointRounding.AwayFromZero);
			MessageBox.Show("      GPA： " + result);
		}

		private void comboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			if(	comboBox1.SelectedIndex != -1 &&
				comboBox2.SelectedIndex != -1 &&
				comboBox3.SelectedIndex != -1 &&
				comboBox4.SelectedIndex != -1 &&
				comboBox5.SelectedIndex != -1)
			{
				button1.Enabled = true;
			}
            button2.Enabled = true;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            button2.Enabled = false;
            button1.Enabled = false;
        }
    }
}
