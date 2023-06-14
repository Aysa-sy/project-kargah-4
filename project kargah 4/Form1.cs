using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kargah_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtop.Text = "";
            txtnum2.Text = "";
            lblresult.Text = "";
            txtnum1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                string op;
                num1 = Convert.ToDouble(txtnum1.Text);
                op = txtop.Text;
                num2 = Convert.ToDouble(txtnum2.Text);
                switch (op)
                {
                    case "+": lblresult.Text = Convert.ToString(num1 + num2); break;
                    case "-": lblresult.Text = Convert.ToString(num1 - num2); break;
                    case "*": lblresult.Text = Convert.ToString(num1 * num2); break;
                    case "/": lblresult.Text = Convert.ToString(num1 / num2); break;
                    default: lblresult.Text = "Invalid Input!"; break;
                }
            }
            catch
            {
                MessageBox.Show("عملیات با خطا مواجه شده است", "خطا");
            }
        }
    }
}
