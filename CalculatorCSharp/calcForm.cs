using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCSharp
{
    public partial class calcForm : Form
    {
        private string[] userArray = new string[20];
        private string userInput;
        private int index = 0;
        private string userSaved = String.Empty;
        private double result;
        private int round = 1;


        public calcForm()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(calcForm_KeyPress);
        }

        #region KeyPress
        void calcForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 48 && e.KeyChar <= 57)//0x30
            {
               //MessageBox.Show("Form.KeyPress: '" +
                                //e.KeyChar.ToString() + "' pressed.");

                switch (e.KeyChar)//(int)e.KeyChar)
                {
                    case '1':
                        button1_Click(sender, e);
                        break;
                    case '2':
                        button2_Click(sender, e);
                        break;
                    case '3':
                        button3_Click_1(sender, e);
                        break;
                    case '4':
                        button4_Click(sender, e);
                        break;
                    case '5':
                        button5_Click(sender, e);
                        break;
                    case '6':
                        button6_Click(sender, e);
                        break;
                    case '7':
                        button7_Click(sender, e);
                        break;
                    case '8':
                        button8_Click(sender, e);
                        break;
                    case '9':
                        button9_Click(sender, e);
                        break;
                    case '0':
                        button0_Click(sender, e);
                        break;
                    case '.':
                        buttonDecimal_Click(sender, e);
                        break;
                    case '+':
                        buttonAdd_Click(sender, e);
                        break;
                    case '-':
                        buttonSubtract_Click(sender, e);
                        break;
                    case '*':
                        buttonMultiply_Click(sender, e);
                        break;
                    case '/':
                        buttonDivide_Click(sender, e);
                        break;
                    case '=':
                        buttonEquals_Click(sender, e);
                        break;
                    case '^':
                        buttonPower_Click(sender, e);
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
        }
        #endregion

        #region Textboxes
        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tallyBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion 

        #region Operands

        private void button1_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            checkRound();
            inputBox.Text = userInput += 0;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            checkRound();
            if (String.IsNullOrEmpty(userInput) == true)
            {
                userInput = "0";
            }
            else if (userInput.Contains(".") == true)
            {
                return;
            }
            inputBox.Text = userInput += ".";
        }

        #endregion

        #region Operations
        private void buttonAdd_Click(object sender, EventArgs e)
        {         
            fillArray("+");
            userInput = String.Empty;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            fillArray("-");
            userInput = String.Empty;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            fillArray("x");
            userInput = String.Empty; 
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            fillArray("/");
            userInput = String.Empty;
        }

        private void buttonSquared_Click(object sender, EventArgs e)
        {
            fillArray("^");
            userInput = "2";
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            fillArray("^");
            userInput = String.Empty;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (round == 2)
            {
                round--;
            }

            if ((String.IsNullOrEmpty(userArray[0]) == true) && (String.IsNullOrEmpty(userInput) == true))
            {
                userInput = "0";
            }
            else if (String.IsNullOrEmpty(userInput) == true)
            {
                return;
            }
            userSaved += "sqrt(" + userInput + ") =";
            tallyBox.Text = userSaved;
            Double num1 = Convert.ToDouble(userInput);
            result = Math.Sqrt(num1);
            userInput = result.ToString();
            inputBox.Text = userInput;
            round++;
        }

        private void buttonFlip_Click(object sender, EventArgs e)
        {
            if (round == 2)
            {
                round--;
            }

            if ((String.IsNullOrEmpty(userArray[0]) == true) && (String.IsNullOrEmpty(userInput) == true))
            {
                userInput = "0";
                inputBox.Text = "Divide by zero error";
                userInput = String.Empty;
                return;
            }
            else if (String.IsNullOrEmpty(userInput) == true)
            {
                return;
            }

            userSaved += "1/(" + userInput + ") =";
            tallyBox.Text = userSaved;
            double num1 = 1;
            double num2 = Convert.ToDouble(userInput);
            result = num1 / num2;
            userInput = result.ToString();
            inputBox.Text = userInput;
            round++;
        }

        private void buttonNegate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(userInput);
            result = num1 * (-1);
            userInput = result.ToString();
            inputBox.Text = userInput;
        }

        #endregion

        #region Delete
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput) == false)
            {
                userInput = userInput.Remove(userInput.Length - 1, 1);
                inputBox.Text = userInput;
                if (userInput.Length == 0)
                {
                    inputBox.Text = "0";
                }
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            userInput = String.Empty;
            inputBox.Text = "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            userInput = String.Empty;
            inputBox.Text = "0";
            userSaved = String.Empty;
            tallyBox.Text = userSaved;
        }

        #endregion

        #region Calculations

        // This function performs order of operations on the userinput after equals is pressed.
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if ((index == 0) && (string.IsNullOrEmpty(userInput) == true))
            {
                return;
            }

            if (String.IsNullOrEmpty(userInput) == true)
            {
                return;
            }

            userArray[index] = userInput;
            tallyBox.Text = userSaved += userInput + '=';
            index++;
            userInput = String.Empty;

            for (int i = 0; i < index; i++)
            {
                if (userArray[i] == "^")
                {
                    calculations(userArray[i - 1], userArray[i + 1], "^", i);
                    i = 0;
                }
            }

            for (int i = 0; i < index; i++)
            {
                if (userArray[i] == "x")
                {
                    calculations(userArray[i - 1], userArray[i + 1], "x", i);
                    i = 0;
                }

                else if (userArray[i] == "/")
                {
                    calculations(userArray[i - 1], userArray[i + 1], "/", i);
                    i = 0;
                }
            }

            for (int i = 0; i < index; i++)
            {
                if (userArray[i] == "+")
                {
                    calculations(userArray[i - 1], userArray[i + 1], "+", i);
                    i = 0;
                }

                else if (userArray[i] == "-")
                {
                    calculations(userArray[i - 1], userArray[i + 1], "-", i);
                    i = 0;
                }
            }

            userInput = userArray[0];
            userSaved = String.Empty;
            userArray[0] = string.Empty;
            inputBox.Text = userInput;
            index = 0;
            round = 2;
        }

        // This function fills the array with userinput after an operator is pressed.
        private void fillArray(string op)
        {
            if (round == 2)
            {
                round--;
            }

            if ((String.IsNullOrEmpty(userArray[0]) == true) && (String.IsNullOrEmpty(userInput) == true))
            {
                userInput = "0";
            } 
            else if (String.IsNullOrEmpty(userInput) == true)
            {
                return;
            }

            userArray[index] = userInput;
            index++;
            userArray[index] = op;
            index++;
            userSaved += userArray[index - 2] + userArray[index -1];
            tallyBox.Text = userSaved;
            userInput = string.Empty;
        }

        // This function performs calculations send from equals function following the order of operations
        private void calculations(String temp1, String temp2, String op, int i) 
        {
            Double num1 = Convert.ToDouble(userArray[i - 1]);
            Double num2 = Convert.ToDouble(userArray[i + 1]);
            
            if (op == "^")
            {
                result = Math.Pow(num1, num2);
            }
            else if (op == "x")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }

            userArray[i - 1] = result.ToString();

            for (int j = i; j <= index; j++)
            {
                userArray[j] = userArray[j + 2];
            }
            index -= 2;
        }

        // This function checks to see if user is starting a new calculation after completing one.
        private void checkRound()
        {
            if (round != 2)
            {
                return;
            }
            round--;
            userInput = String.Empty;
            inputBox.Text = userInput;
            tallyBox.Text = userSaved;
        }

        #endregion
    }
}
