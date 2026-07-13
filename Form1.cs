using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
       double secondNumber = 0;
        enCalculator currentOperation = enCalculator.enNone;
        bool IsNewInput = true;
        bool isdarkMode = true;
     public enum enCalculator
        {
            enNone,
            enAdd,
            enSubtract,
            enMultiply,
            enDivide,
            enMod,
            enPower,
            enSquareRoot,
            enPersent,




        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(label1.Text);
            if (currentOperation==enCalculator.enNone)
                label1.Text = ((num ) / 100).ToString();
            else
            label1.Text=((num*firstNumber) /100).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }
        private void AddDot()
        {
            if (!label1.Text.Contains("."))
            {
                label1.Text += ".";
            }

        }
        private void button23_Click(object sender, EventArgs e)
        {
            AddDot();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
           firstNumber=  Convert.ToDouble(label1.Text);
            currentOperation = enCalculator.enAdd;
            IsNewInput = true;
          
        }
       private string CalculateNumbers(char operation,double num1)
        {
            secondNumber = Convert.ToDouble(label1.Text);
            switch (operation)
            {
                 
                case '+':
                    {
                        return (num1 + secondNumber).ToString();
                        break;
                    }
                case '-':
                    {
                        return (num1 - secondNumber).ToString();
                        break;
                    }

                case '*':
                    {
                        return (num1 * secondNumber).ToString();
                        break;
                    }

                case '/':
                    {
                        return (num1 / secondNumber).ToString();
                        break;
                    }

                case '%':
                    {
                        return (num1 % secondNumber).ToString();
                        break;
                    }
                default:
                    return "";
                




            }



        }

        private void CalculateNumberToLabeltxt()
        {

            switch (currentOperation)
            {
                case enCalculator.enAdd:

                    label1.Text = CalculateNumbers('+', firstNumber);
                    break;
                case enCalculator.enSubtract:
                    label1.Text = CalculateNumbers('-', firstNumber);
                    break;
                case enCalculator.enMultiply:
                    label1.Text = CalculateNumbers('*', firstNumber);
                    break;
                case enCalculator.enDivide:

                    if (secondNumber != 0)
                        label1.Text = CalculateNumbers('/', firstNumber);
                    else
                        label1.Text = "Error";
                    break;
                case enCalculator.enMod:

                    if (secondNumber != 0)
                        label1.Text = CalculateNumbers('%', firstNumber);
                    else
                        label1.Text = "Error";
                    break;
                default:
                    break;




            }


        }
        private void button24_Click(object sender, EventArgs e)
        {
            CalculateNumberToLabeltxt();
             
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            currentOperation = enCalculator.enSubtract;
            IsNewInput = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            currentOperation = enCalculator.enMultiply;
            IsNewInput = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            currentOperation = enCalculator.enDivide;
            IsNewInput=true;
        }



        private void button9_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            AddNumberTotxt(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            AddNumberTotxt(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            double firstNumber = 0;
            double secondNumber = 0;
            enCalculator currentOperation = enCalculator.enNone;
            bool IsNewInput = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(label1.Text);
            currentOperation = enCalculator.enMod;
            IsNewInput = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(label1.Text);
            label1.Text = (num * num).ToString();
        }
        private void Sqrt()
        {

            double num = Convert.ToDouble(label1.Text);
            if (num > 0)
                label1.Text = Math.Sqrt(num).ToString();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            Sqrt();
        }
        private void AddNumberTotxt(object sender)
        {
            Button btn = (Button)sender;
            if (label1.Text == "0" || IsNewInput)
            {
                label1.Text = btn.Text;
                IsNewInput = false;


            }
            else
            {
                label1.Text += btn.Text;
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddNumberTotxt(sender);
        }
        private void ReturndNUmberPositiveOrNegative()
        {

            double num = Convert.ToDouble(label1.Text);

            if (num > 0)
                label1.Text = (-num).ToString();
            else
            {
                label1.Text = (num).ToString();
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            ReturndNUmberPositiveOrNegative();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (isdarkMode)
            {

                this.BackColor = Color.White;
                guna2Button1.Text = "Dark Mode";
               guna2Button1.ForeColor = Color.Black;
                guna2Button1.BackColor = Color.White;
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                isdarkMode = false;
            }
            else
            {
                guna2Button1.Text = "light Mode";
                guna2Button1.ForeColor= Color.White;
                this.BackColor = Color.FromArgb(64, 64, 64);
                label1.ForeColor = Color.White;
                label1.BackColor = Color.DarkGray;

                isdarkMode = true;

            }
        }
    }

}
