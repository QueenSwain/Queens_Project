using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        double SecondNumber;
        string Operation;
        double Result;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnClick_Event(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBox1.Text == "0")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + btn.Text;
            }

        }

        private void nCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void nDot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            //btn1 sender object will send the value fo selected button object(/,+,-,*)
            //entering the first value converting string to double for caluclation
            //clicking on operator for add,mul,sub,div
            //after entering 1st value and operator making text back to 0
            Button btn1 = sender as Button;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            Operation = btn1.Text;
            textBox1.Text = "0";
           
        }

        //TODO :to clear one digit after entering as first no or sec no
        //TODO: to show both the numbers in the textbox and operator then will show 1+2=3 in as text
        private void btnEqual_Click(object sender, EventArgs e)
        {
            SecondNumber = Convert.ToDouble(textBox1.Text);
            switch (Operation)
            {
                case "+":
                    Result = (FirstNumber + SecondNumber); //sum of 2no will store in Result var
                    textBox1.Text = Convert.ToString(Result); //showing the result in textbox as a string.
                    FirstNumber = Result; 
                    break;
                case "-":
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    break;
                case "*":
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    break;
                case "/":
                    {
                        if (SecondNumber == 0)
                        {
                            Font myfont = new Font("Times New Roman", 12.0f);
                            textBox1.Font = myfont;
                            textBox1.Text = "Cannot devide by zero!";
                        }
                        else
                        {
                            Result = (FirstNumber / SecondNumber);
                            textBox1.Text = Convert.ToString(Result);
                            FirstNumber = Result;

                        }
                        break;
                    }


            }
        }
    }
}
          
