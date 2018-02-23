using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double ResultValue = 0;
        String operationPerformed = "";
        bool isoperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isoperationPerformed))
                textBox_Result.Clear();
            isoperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelcurrentoperation.Text = ResultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                ResultValue = Double.Parse(textBox_Result.Text);
                labelcurrentoperation.Text = ResultValue + " " + operationPerformed;
                isoperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            ResultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (ResultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (ResultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (ResultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (ResultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            ResultValue = Double.Parse(textBox_Result.Text);
            labelcurrentoperation.Text = "";
        }
    }
}
